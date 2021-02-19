using InfoLib;
using InfoLibClientSend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestElement;

namespace TestClient
{
    public partial class Form1 : Form
    {
        // Приймання даних
        private UdpClient client;

        // Передача даних
        private UdpClient client_2;

        private IPAddress groupAddres;
        private IPAddress groupAddres_2;

        private int localPort;
        private int localPort_2;

        private int remotePort;
        private int remotePort_2;

        private int ttl;

        private IPEndPoint remoteEP;
        private IPEndPoint remoteEP_2;

        private UnicodeEncoding encoding = new UnicodeEncoding();


        bool GiveAccess = false;
        int n = 0;


        string LOGIN = string.Empty;
        int USER_ID;
        int? GROUP_ID;
        string GROUP_NAME = string.Empty;

        int testPassed = 0;
        int noGroup = 0;

        List<DBTestData> dBTestDataList = new List<DBTestData>();

        public Form1()
        {
            InitializeComponent();

            //
            groupAddres = IPAddress.Parse("234.5.5.11");
            groupAddres_2 = IPAddress.Parse("234.5.5.15");

            localPort = 7778;
            remotePort = 7777;

            localPort_2 = 8778;
            remotePort_2 = 8777;

            ttl = 32;

            client = new UdpClient(localPort);
            client.JoinMulticastGroup(groupAddres, ttl);

            client_2 = new UdpClient(localPort_2);
            client_2.JoinMulticastGroup(groupAddres_2, ttl);

            remoteEP = new IPEndPoint(groupAddres, remotePort);
            remoteEP_2 = new IPEndPoint(groupAddres_2, remotePort_2);

            Thread receiver = new Thread(Listener);
            receiver.IsBackground = true;
            receiver.Start();
            //


            while (true)
            {
                Form2 form = new Form2();
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.Cancel)
                {
                    n = 1;
                    break;
                }
                else
                {
                    MSG_SEND("CONNECT", form.textBox1.Text, form.textBox2.Text);
                    //
                    Thread.Sleep(2000);
                    //

                    if (GiveAccess)
                    {
                        LOGIN = form.textBox1.Text;
                        break;
                    }
                }

            }

            
        }

        private void Listener()
        {
            while (true)
            {
                IPEndPoint ep = null;
                byte[] mas = client.Receive(ref ep);
                using(MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    ms.Write(mas, 0, mas.Length);
                    ms.Seek(0, SeekOrigin.Begin);
                    Info info = (Info)bf.Deserialize(ms);

                    if (info.MSG == "CONNECTED_TRUE")
                    {
                        GiveAccess = true;

                        label1.Text = info.DBUserData.FName;
                        label2.Text = info.DBUserData.LName;

                        USER_ID = info.DBUserData.Id;
                        GROUP_ID = info.DBUserData.GroupId;

                        if (GROUP_ID == null && noGroup == 0)
                        {
                            MessageBox.Show("Admin should first add you to the group!\nThen restart app", "ClientAlert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            noGroup = 1;
                        }
                        
                    }
                    else if (info.MSG == "EXIT")
                    {
                        Application.Exit();
                    }
                    else if (info.MSG == "LOAD_TESTS_TRUE")
                    {
                       
                        if (GROUP_NAME == string.Empty)
                        {
                            GROUP_NAME = info.DBUserData.FName;
                            Invoke(new Action(() =>
                            {
                                label3.Text = "Group: " + GROUP_NAME;
                            }));
                        }

                        dBTestDataList = info.DBTestData;

                        Invoke(new Action(() =>
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.Rows.Clear();
                            dataGridView1.DataSource = dBTestDataList;
                        }));
                        
                    }
                    else if(info.MSG == "RETURN_TEST")
                    {
                        if (testPassed == 1)
                        {
                            continue;
                        }

                        Data data = info.Data;

                        List<TestAnsws> answs = new List<TestAnsws>();

                        for (int i = 0; i < data.Tests.Count(); i++)
                        {

                            FormPassTest form = new FormPassTest();
                            form.groupBox1.Text = $"{i+1} || {data.Tests.Count()}";
                            form.textBox1.Text = data.Tests[i].Question;

                            for (int j = 0; j < data.Tests[i].Answers.Count(); j++)
                            {
                                form.listBox1.Items.Add(data.Tests[i].Answers[j]);
                            }

                            DialogResult res = form.ShowDialog();

                            if (res == DialogResult.OK)
                            {
                                
                                if (form.listBox1.SelectedItem.ToString() == data.Tests[i].CorectAnswer)
                                {
                                    answs.Add(new TestAnsws() { Question = data.Tests[i].Question, IsAnswerCorect = true });
                                }
                                else
                                {
                                    answs.Add(new TestAnsws() { Question = data.Tests[i].Question, IsAnswerCorect = false });
                                }

                            }

                            
                        }

                        var trueAswers = answs.Where(t => t.IsAnswerCorect == true).Count();
                        var totalAnswers = data.Tests.Count();

                        double ress = 0;
                        try
                        {
                            ress = (trueAswers * 100) / totalAnswers;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("ERROR", "ClientAlert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        var mark = Convert.ToInt32(ress);

                        MessageBox.Show($"Your mark is: {mark}%", "TestClient", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        InfoLibClientSendClass inf = new InfoLibClientSendClass();
                        inf.MSG = "TEST_PASSED_DATA";
                        inf.GroupId = GROUP_ID;
                        inf.UserId = USER_ID;
                        inf.TestId = info.DBTestData[0].Id;
                        inf.TestMark = mark;
                        inf.remoteEP = remoteEP_2;

                        SenderDataClient(inf);



                        testPassed = 1;

                    }
                }
            }
        }

        private void SenderDataClient(object obj)
        {
            InfoLibClientSendClass info = obj as InfoLibClientSendClass;

            BinaryFormatter bf = new BinaryFormatter();
            byte[] data = null;

            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, info);
                data = ms.ToArray();
                client_2.Send(data, data.Length, info.remoteEP);
            }

        }

        private void MSG_SEND(string msg, string login, string password)
        {
            InfoLibClientSendClass info = new InfoLibClientSendClass();
            info.MSG = msg;
            info.remoteEP = remoteEP_2;
            info.Login = login;
            info.Password = password;
            info.TestMark = null;
            info.GroupId = null;
            info.TestId = null;
            info.UserId = null;
            SenderDataClient(info);
        }


        private void SEND_MESSAGE(string msg, string login)
        {
            InfoLibClientSendClass info = new InfoLibClientSendClass();
            info.MSG = msg;
            info.remoteEP = remoteEP_2;
            info.Login = login;
            info.Password = null;
            info.TestMark = null;
            info.GroupId = null;
            info.TestId = null;
            info.UserId = null;
            SenderDataClient(info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (n == 1)
            {
                Application.Exit();
            }
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            SEND_MESSAGE("LOAD_TESTS", LOGIN);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                testPassed = 0;
                var testId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                InfoLibClientSendClass info = new InfoLibClientSendClass();
                info.MSG = "PASS_TEST";
                info.remoteEP = remoteEP_2;
                info.TestId = testId;
                info.UserId = USER_ID;
                SenderDataClient(info);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR", "ClientAlert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
