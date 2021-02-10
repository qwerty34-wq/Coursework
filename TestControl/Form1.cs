using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestElement;

namespace TestControl
{
    public partial class Form1 : Form
    {
        TestElem elem;
        List<string> answs = new List<string>();
        int n = 0;

        List<TestElem> testElems = new List<TestElem>();

        public Form1()
        {
            InitializeComponent();

            ElemBlock(false);
        }

        private void ElemBlock(bool onoff)
        {
            textBox4.Enabled = onoff;
            textBox3.Enabled = onoff;
            checkBox1.Enabled = onoff;
            textBox5.Enabled = onoff;
            button1.Enabled = onoff;
            button2.Enabled = onoff;
            button3.Enabled = onoff;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" && textBox1.Text.Trim() != "")
            {
                ElemBlock(true);
            }
            else
            {
                ElemBlock(false);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                ElemBlock(true);
            }
            else
            {
                ElemBlock(false);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                if (textBox4.Text.Trim() != "" && textBox3.Text.Trim() != "")
                {
                    elem = new TestElem() { Question = textBox4.Text.Trim() };

                    answs.Add(textBox3.Text.Trim());

                    if (checkBox1.Checked)
                    {
                        elem.CorectAnswer = textBox3.Text.Trim();
                        checkBox1.Checked = false;
                        checkBox1.Enabled = false;

                        checkBox1.Text = $"IsRight  ({elem.CorectAnswer})";
                    }

                    textBox4.Enabled = false;
                    textBox3.Clear();

                    textBox1.Enabled = textBox2.Enabled = false;

                    ShowInListBox();

                    n++;
                }
            }
            else
            {
                if (textBox3.Text.Trim() != "")
                {
                    //
                    foreach (var t in answs)
                    {
                        if (t == textBox3.Text.Trim())
                        {
                            MessageBox.Show("There are such answer!");
                            return;
                        }
                    }
                    //

                    answs.Add(textBox3.Text.Trim());

                    if (checkBox1.Checked)
                    {
                        elem.CorectAnswer = textBox3.Text.Trim();
                        checkBox1.Checked = false;
                        checkBox1.Enabled = false;

                        checkBox1.Text = $"IsRight  ({elem.CorectAnswer})";

                        button1.Enabled = true;
                        button3.Enabled = true;
                    }

                    textBox3.Clear();

                    ShowInListBox();

                    n++;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (n >= 2 && elem.CorectAnswer != null)
            {
                elem.Answers = new List<string>();
                elem.Answers.AddRange(answs);

                answs.Clear();

                testElems.Add(elem);

                elem = null;

                listBox1.Items.Clear();

                label4.Text = $"Questions  ({testElems.Count()})";

                textBox4.Clear();
                textBox4.Enabled = true;

                checkBox1.Text = "IsRight";

                if (!checkBox1.Enabled)
                {
                    checkBox1.Enabled = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

                n = 0;

                MessageBox.Show($"Question: {testElems[testElems.Count() - 1].Question}\nNum of answers: {testElems[testElems.Count() - 1].Answers.Count()}\nCorect Answer: {testElems[testElems.Count() - 1].CorectAnswer}");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void ShowInListBox()
        {
            listBox1.Items.Add(answs[answs.Count() - 1]);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (testElems.Count() == 0)
            {
                MessageBox.Show("You should first add some tests!");
                return;
            }

            if (textBox5.Text.Trim() == "")
            {
                textBox5.Text = $"{textBox2.Text.Trim()}_{textBox1.Text.Trim()}";
            }

            if (!Directory.Exists("Tests"))
            {
                Directory.CreateDirectory("Tests");
            }

            if (File.Exists($"Tests/{textBox5.Text.Trim()}.xml"))
            {
                MessageBox.Show("There are file with this name");
                return;
            }


            Data data = new Data();
            data.Author = textBox1.Text.Trim();
            data.Title = textBox2.Text.Trim();
            data.Tests = new List<TestElem>();
            data.Tests.AddRange(testElems);

            XmlSerializer formatter = new XmlSerializer(typeof(Data));

            using (FileStream fs = new FileStream($"Tests/{textBox5.Text.Trim()}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, data);

                MessageBox.Show($"File {textBox5.Text.Trim()}.xml saved successfuly");
            }

            label4.Text = "Questions";
            checkBox1.Text = "IsRight";

            listBox1.Items.Clear();

            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox1.Enabled = textBox2.Enabled = true;

            checkBox1.Checked = false;

            testElems.Clear();
            answs.Clear();

            n = 0;
        }

        private void ReWriteListBox()
        {
            listBox1.Items.Clear();
            foreach (var t in answs)
            {
                listBox1.Items.Add(t);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem.ToString() == elem.CorectAnswer)
                {
                    elem.CorectAnswer = null;
                    checkBox1.Enabled = true;
                    checkBox1.Text = "IsRight";
                    button1.Enabled = false;
                    button3.Enabled = false;
                }

                answs.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem);
                ReWriteListBox();
                n--;
            }
            else
            {
                MessageBox.Show("No selected items!");
            }
            
        }
    }
}
