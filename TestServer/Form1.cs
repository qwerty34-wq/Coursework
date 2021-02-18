using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestElement;

namespace TestServer
{
    public partial class Form1 : Form
    {
        static GenericUnitOfWork work = new GenericUnitOfWork(new Context(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        IGenericRepository<User> repoUser = work.Repository<User>();
        IGenericRepository<Group> repoGroup = work.Repository<Group>();
        IGenericRepository<Test> repoTest = work.Repository<Test>();
        IGenericRepository<Grade> repoGrade = work.Repository<Grade>();
        IGenericRepository<GroupTest> repoGroupTest = work.Repository<GroupTest>();

        public Form1()
        {
            InitializeComponent();

            tabControl1.SelectedTab = tabControl1.TabPages[0];

            //var bs = repoGroup.GetAllData().ToList();
            ShowGroups(DGV_ShowAllGroups);
        }


        //
        //
        // Methods
        //
        //


        // Show Groups
        public void ShowGroups(DataGridView dataGridView)
        {
            var bs = repoGroup.GetAllData().Select(p => new { p.Id, p.Name }).ToList();
            dataGridView.DataSource = bs;
        }
        //

        // CheckButton
        public void CheckButton(Button button, TextBox textBox)
        {
            if (textBox.Text.Length >= 1 && textBox.Text.Length <= 50)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }
        //

        //CheckIfExistsSuchElement
        public Group CheckIfExistsSuchGroup(string name)
        {
            var elem = repoGroup.FirstOrDefault(t => t.Name == name);
            return elem;
        }
        //


        // Show Users
        public void ShowUsers(DataGridView dataGridView)
        {
            var bs = repoUser.GetAllData().Select(p => new { p.Id, p.FName, p.LName, p.Login, p.Password, p.IsAdmin }).ToList();

            dataGridView.DataSource = bs;
        }
        //

        // CheckUsersField
        public bool CheckUsersField(List<TextBox> textBoxes)
        {
            foreach (var t in textBoxes)
            {
                if (t.Text.Trim() == string.Empty || t.Text.Length > 50)
                {
                    return false;
                }
            }

            return true;
        }
        //

        // ClearAll
        public void ClearAll(List<TextBox> textBoxes)
        {
            foreach (var t in textBoxes)
            {
                t.Clear();
            }
        }
        //






        //
        //
        // Tabs
        //
        //


        // Groups
        private void ShowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];

            ShowGroups(DGV_ShowAllGroups);
        }
        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];

            ShowGroups(DGV_AddGroup);
        }
        private void UpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];

            ShowGroups(DGV_UpdateGroup);
        }
        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[3];

            comboBox_AddUserToGroup.Items.Clear();

            var groups = repoGroup.GetAllData().ToList();
            foreach (var t in groups)
            {
                comboBox_AddUserToGroup.Items.Add(t.Name);
            }

            ShowUsers(DGV_AddUserToGroup_AllStudents);
        }
        private void ShowUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[4];

            comboBox_ShowUsersInGroup.Items.Clear();

            var groups = repoGroup.GetAllData().ToList();
            foreach (var t in groups)
            {
                comboBox_ShowUsersInGroup.Items.Add(t.Name);
            }

            
        }

        // Users
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[5];

            ShowUsers(DGV_ShowUsers);

        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[6];

            ShowUsers(DGV_AddUsers);
        }
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[7];

            ShowUsers(DGV_UpdateUsers);
        }

        // Tests
        private void LoadTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[8];
        }
        private void ShowAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[9];

            var bs = repoTest.GetAllData().Select(t => new { Id = t.Id, Author = t.Author, Title = t.Title, Filename = t.Filename, NumOfQuestions = t.NumOfQuestions, TimeInMinutes = t.Time });
            DGV_ShowAllTests.DataSource = bs.ToList();
        }
        private void AsignesTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[10];

            DGV_AsignesTest_TestsForGroup.DataSource = null;
            DGV_AsignesTest_TestsForGroup.Rows.Clear();

            comboBox_AsignesTest_Groups.Items.Clear();

            var groups = repoGroup.GetAllData().ToList();
            foreach (var t in groups)
            {
                comboBox_AsignesTest_Groups.Items.Add(t.Name);
            }

            var bs = repoTest.GetAllData().Select(t => new { Id = t.Id, Author = t.Author, Title = t.Title, Filename = t.Filename, NumOfQuestions = t.NumOfQuestions, TimeInMinutes = t.Time });
            DGV_AsignesTest_AllTests.DataSource = bs.ToList();
        }
        private void ShowTestsOfGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[11];

            DGV_ShowTestsOfGroup.DataSource = null;
            DGV_ShowTestsOfGroup.Rows.Clear();

            comboBox_ShowTestsOfGroup.Items.Clear();

            var groups = repoGroup.GetAllData().ToList();
            foreach (var t in groups)
            {
                comboBox_ShowTestsOfGroup.Items.Add(t.Name);
            }

        }


        //
        //
        // Event Handlers
        //
        //

        
        // Groups

        private void Button_AddGroup_Click(object sender, EventArgs e)
        {
            if (textBox_AddGroup_Name.Text.Trim() != string.Empty)
            {
                var res = CheckIfExistsSuchGroup(textBox_AddGroup_Name.Text.Trim());
                if (res != null)
                {
                    MessageBox.Show("Ther are such group with this name.\nTry another group name", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {

                    repoGroup.Add(new Group() { Name = textBox_AddGroup_Name.Text.Trim() });
                    ShowGroups(DGV_AddGroup);
                    textBox_AddGroup_Name.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Field is empty", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TextBox_AddGroup_Name_TextChanged(object sender, EventArgs e)
        {
            CheckButton(button_AddGroup, textBox_AddGroup_Name);
        }


        private void Button_UpdateGroup_Click(object sender, EventArgs e)
        {
            if (textBox_UpdateGroup_NewName.Text.Trim() != string.Empty)
            {

                if (DGV_UpdateGroup.SelectedRows[0].Cells["Name"].Value.ToString() == textBox_UpdateGroup_NewName.Text.Trim())
                {
                    MessageBox.Show("Name is not changed", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var res = CheckIfExistsSuchGroup(textBox_UpdateGroup_NewName.Text.Trim());
                if (res != null)
                {
                    MessageBox.Show("Ther are such group with this name.\nTry another group name", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    int _id = Convert.ToInt32(DGV_UpdateGroup.SelectedRows[0].Cells["Id"].Value);

                    var group = repoGroup.FindById(_id);

                    group.Name = textBox_UpdateGroup_NewName.Text.Trim();

                    repoGroup.Update(group);

                    ShowGroups(DGV_UpdateGroup);

                    textBox_UpdateGroup_NewName.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
            }

        }

        private void TextBox_UpdateGroup_NewName_TextChanged(object sender, EventArgs e)
        {
            CheckButton(button_UpdateGroup, textBox_UpdateGroup_NewName);
        }


        private void ComboBox_AddUserToGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_AddUserToGroup.SelectedItem.ToString()).Id;

            var bs = repoUser.GetAllData().Where(t => t.GroupId == groupId).Select(t => new { Id = t.Id, FName = t.FName, LName = t.LName, Login = t.Login, Password = t.Password,
            IsAdmin = t.IsAdmin, GroupId = t.GroupId});

            DGV_AddUserToGroup_NewGroup.DataSource = bs.ToList();
        }

        private void Button_AddUserToGroup_Click(object sender, EventArgs e)
        {
            var userId = DGV_AddUserToGroup_AllStudents.SelectedRows[0].Cells["Id"].Value;
            var groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_AddUserToGroup.SelectedItem.ToString()).Id;

            //
            //var admins_group = repoGroup.FirstOrDefault(t => t.Name == "admins_group");
            //


            var user = repoUser.FindById(userId);
            user.GroupId = groupId;

            //
            //if (admins_group.Id == groupId)
            //{
            //    user.IsAdmin = true;
            //}
            //

            repoUser.Update(user);


            var bs = repoUser.GetAllData().Where(t => t.GroupId == groupId).Select(t => new { Id = t.Id, FName = t.FName, LName = t.LName, Login = t.Login,
                Password = t.Password, IsAdmin = t.IsAdmin, GroupId = t.GroupId });

            DGV_AddUserToGroup_NewGroup.DataSource = bs.ToList();
        }

        private void ComboBox_ShowUsersInGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            var groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_ShowUsersInGroup.SelectedItem.ToString()).Id;

            var bs = repoUser.GetAllData().Where(t => t.GroupId == groupId).Select(t => new {
                Id = t.Id,
                FName = t.FName,
                LName = t.LName,
                Login = t.Login,
                Password = t.Password,
                IsAdmin = t.IsAdmin,
                GroupId = t.GroupId
            });

            DGV_ShowUsersInGroup.DataSource = bs.ToList();
        }

        private void Button_ShowUsersInGroup_RemoveStudent_Click(object sender, EventArgs e)
        {
            var userId = DGV_ShowUsersInGroup.SelectedRows[0].Cells["Id"].Value;
            var user = repoUser.FindById(userId);
            user.GroupId = null;
            repoUser.Update(user);


            var groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_ShowUsersInGroup.SelectedItem.ToString()).Id;
            var bs = repoUser.GetAllData().Where(t => t.GroupId == groupId).Select(t => new {
                Id = t.Id,
                FName = t.FName,
                LName = t.LName,
                Login = t.Login,
                Password = t.Password,
                IsAdmin = t.IsAdmin,
                GroupId = t.GroupId
            });

            DGV_ShowUsersInGroup.DataSource = bs.ToList();
        }






        // Users

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>() { textBox_FirstName, textBox_LastName, textBox_Login, textBox_Password, textBox_ConfirmPassword };
            var isFieldValid = CheckUsersField(textBoxes);

            if (!isFieldValid)
            {
                MessageBox.Show("There are empty field or field with length > 50!", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_Password.Text != textBox_ConfirmPassword.Text)
            {
                MessageBox.Show("Passwords are not similar", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = repoUser.FirstOrDefault(t => t.Login == textBox_Login.Text.Trim());
            if (res != null)
            {
                MessageBox.Show("There are User with this login!\nPlease, choose another login", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                User user = new User()
                {
                    FName = textBox_FirstName.Text.Trim(),
                    LName = textBox_LastName.Text.Trim(),
                    Login = textBox_Login.Text.Trim(),
                    Password = textBox_Password.Text.Trim(),
                    IsAdmin = checkBox_IsAdmin.Checked,
                };


                if (!checkBox_IsAdmin.Checked)
                {
                    user.GroupId = null;
                }
                else
                {
                    try
                    {
                        var adm_group = repoGroup.FirstOrDefault(t => t.Name == "admins_group");
                        user.GroupId = adm_group.Id;
                    }
                    catch (Exception ex)
                    {
                        user.GroupId = null;
                    }
                }


                repoUser.Add(user);

                ShowUsers(DGV_AddUsers);

                ClearAll(textBoxes);
                checkBox_IsAdmin.Checked = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DGV_UpdateUsers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_FirstName_Upd.Text = DGV_UpdateUsers.SelectedRows[0].Cells["FName"].Value.ToString();
                textBox_LastName_Upd.Text = DGV_UpdateUsers.SelectedRows[0].Cells["LName"].Value.ToString();
                textBox_Login_Upd.Text = DGV_UpdateUsers.SelectedRows[0].Cells["Login"].Value.ToString();
                textBox_Password_Upd.Text = DGV_UpdateUsers.SelectedRows[0].Cells["Password"].Value.ToString();
                textBox_ConfirmPassword_Upd.Text = DGV_UpdateUsers.SelectedRows[0].Cells["Password"].Value.ToString();

                bool cheched = Convert.ToBoolean(DGV_UpdateUsers.SelectedRows[0].Cells["IsAdmin"].Value);
                if (cheched)
                {
                    checkBox_IsAdmin_Upd.Checked = true;
                }
                else
                {
                    checkBox_IsAdmin_Upd.Checked = false;
                }
            }
            catch(Exception ex)
            { }
        }

        private void Button_Update_User_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>() { textBox_FirstName_Upd, textBox_LastName_Upd, textBox_Login_Upd, textBox_Password_Upd,
                textBox_ConfirmPassword_Upd };



            var isFieldValid = CheckUsersField(textBoxes);

            if (!isFieldValid)
            {
                MessageBox.Show("There are empty field or field with length > 50!", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_Password_Upd.Text != textBox_ConfirmPassword_Upd.Text)
            {
                MessageBox.Show("Passwords are not similar", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DGV_UpdateUsers.SelectedRows[0].Cells["Login"].Value.ToString() != textBox_Login_Upd.Text.Trim())
            {

                var res = repoUser.FirstOrDefault(t => t.Login == textBox_Login_Upd.Text.Trim());
                if (res != null)
                {
                    MessageBox.Show("There are User with this login!\nPlease, choose another login", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

           


            var _user = repoUser.FindById(Convert.ToInt32(DGV_UpdateUsers.SelectedRows[0].Cells["Id"].Value));


            _user.FName = textBox_FirstName_Upd.Text.Trim();
            _user.LName = textBox_LastName_Upd.Text.Trim();
            _user.Login = textBox_Login_Upd.Text.Trim();
            _user.Password = textBox_Password_Upd.Text.Trim();
            _user.IsAdmin = checkBox_IsAdmin_Upd.Checked;
            _user.GroupId = null;
           

            if (checkBox_IsAdmin_Upd.Checked)
            {
                _user.GroupId = repoGroup.FirstOrDefault(t => t.Name == "admins_group").Id;
            }

            repoUser.Update(_user);
            ShowUsers(DGV_UpdateUsers);
        }





        // Tests

        string path = string.Empty;
        string filename = string.Empty;

        private void Button_LoadTest_File_Click(object sender, EventArgs e)
        {
            //openFileDialog1.DefaultExt = "*.xml";

            openFileDialog1.Filter = "Xml files (*.xml)|*.xml";

            openFileDialog1.Title = "Upload File";
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.Cancel)
                return;

            path = openFileDialog1.FileName;
            filename = openFileDialog1.SafeFileName;

            if (Directory.Exists("UploadedFiles"))
            {
                if (File.Exists($@"UploadedFiles\{filename}"))
                {
                    MessageBox.Show("There are already such test", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    path = string.Empty;
                    filename = string.Empty;

                    return;
                }
            }


            //string destFile = $@"UploadedFiles\{filename}";


            XmlSerializer formatter = new XmlSerializer(typeof(Data));
            Data data = new Data();

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                data = (Data)formatter.Deserialize(fs);
            }

            textBox_LoadTest_Author.Text = data.Author;
            textBox_LoadTest_NameOfTest.Text = data.Title;
            textBox_LoadTest_NumOfQuestions.Text = data.Tests.Count().ToString();
        }

        private void Button_LoadTest_SaveTest_Click(object sender, EventArgs e)
        {
            if (path == string.Empty || filename == string.Empty)
            {
                MessageBox.Show("Select file first", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists("UploadedFiles"))
            {
                Directory.CreateDirectory("UploadedFiles");
            }

            string destFile = $@"UploadedFiles\{filename}";

            File.Copy(path, destFile);

            int hours = Convert.ToInt32(numericUpDown_LoadTest_Hour.Value);
            int minutes = Convert.ToInt32(numericUpDown_LoadTest_Minute.Value);

            int min_in_hours = hours * 60;

            int total_time = min_in_hours + minutes;

            Test test = new Test()
            {
                Author = textBox_LoadTest_Author.Text,
                Title = textBox_LoadTest_NameOfTest.Text,
                NumOfQuestions = Convert.ToInt32(textBox_LoadTest_NumOfQuestions.Text),
                Filename = filename,
                Time = total_time
            };

            repoTest.Add(test);

            textBox_LoadTest_Author.Clear();
            textBox_LoadTest_NameOfTest.Clear();
            textBox_LoadTest_NumOfQuestions.Clear();
            numericUpDown_LoadTest_Hour.Value = 0;
            numericUpDown_LoadTest_Minute.Value = 1;

            path = string.Empty;
            filename = string.Empty;
        }

        private void Button_LoadTest_CancelTest_Click(object sender, EventArgs e)
        {
            textBox_LoadTest_Author.Clear();
            textBox_LoadTest_NameOfTest.Clear();
            textBox_LoadTest_NumOfQuestions.Clear();
            numericUpDown_LoadTest_Hour.Value = 0;
            numericUpDown_LoadTest_Minute.Value = 1;

            path = string.Empty;
            filename = string.Empty;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var testId = Convert.ToInt32(DGV_ShowAllTests.SelectedRows[0].Cells["Id"].Value);

            var test = repoTest.FindById(testId);

            File.Delete($@"UploadedFiles\{test.Filename}");

            repoTest.Remove(test);

            var res = repoGroupTest.FindAll(t => t.TestId == testId).ToList();
            foreach (var t in res)
            {
                repoGroupTest.Remove(t);
            }

            var bs = repoTest.GetAllData().Select(t => new { Id = t.Id, Author = t.Author, Title = t.Title, Filename = t.Filename, NumOfQuestions = t.NumOfQuestions, TimeInMinutes = t.Time });
            DGV_ShowAllTests.DataSource = bs.ToList();
        }

        private void ComboBox_AsignesTest_Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_AsignesTest_Groups.SelectedItem.ToString()).Id;
            var group = repoGroup.FindById(groupId);

            var bs = from g in repoGroup.GetAllData()
                     join gt in repoGroupTest.GetAllData() on g.Id equals gt.GroupId
                     join t in repoTest.GetAllData() on gt.TestId equals t.Id
                     where g.Id == groupId
                     select new { GroupName = g.Name, Author = t.Author, Title = t.Title, NumOfQuestions = t.NumOfQuestions, Time = t.Time };

            DGV_AsignesTest_TestsForGroup.DataSource = bs.ToList();
        }

        private void Button_AsignesTest_AddTest_Click(object sender, EventArgs e)
        {
            var testId = Convert.ToInt32(DGV_AsignesTest_AllTests.SelectedRows[0].Cells["Id"].Value);
            int groupId;
            try
            {
                groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_AsignesTest_Groups.SelectedItem.ToString()).Id;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Сhoose group first!", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GroupTest groupTest = new GroupTest() { GroupId = groupId, TestId = testId };

            var res = repoGroupTest.FirstOrDefault(t => t.GroupId == groupId && t.TestId == testId);
            if (res != null)
            {
                MessageBox.Show("You assigned this test once for this group", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            repoGroupTest.Add(new GroupTest() { GroupId = groupId, TestId = testId });

            var bs = from g in repoGroup.GetAllData()
                     join gt in repoGroupTest.GetAllData() on g.Id equals gt.GroupId
                     join t in repoTest.GetAllData() on gt.TestId equals t.Id
                     where g.Id == groupId
                     select new { GroupName = g.Name, Author = t.Author, Title = t.Title, NumOfQuestions = t.NumOfQuestions, Time = t.Time };

            DGV_AsignesTest_TestsForGroup.DataSource = bs.ToList();
        }

        private void ComboBox_ShowTestsOfGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_ShowTestsOfGroup.SelectedItem.ToString()).Id;

            var bs = from g in repoGroup.GetAllData()
                     join gt in repoGroupTest.GetAllData() on g.Id equals gt.GroupId
                     join t in repoTest.GetAllData() on gt.TestId equals t.Id
                     where g.Id == groupId
                     select new { GroupName = g.Name, Author = t.Author, Title = t.Title, NumOfQuestions = t.NumOfQuestions, Time = t.Time };

            DGV_ShowTestsOfGroup.DataSource = bs.ToList();
        }

        private void Button_ShowTestsOfGroup_RemoveTest_Click(object sender, EventArgs e)
        {
            int groupId;
            try
            {
                groupId = repoGroup.FirstOrDefault(t => t.Name == comboBox_ShowTestsOfGroup.SelectedItem.ToString()).Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("First select group", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string author;
            string title;
            try
            {
                author = DGV_ShowTestsOfGroup.SelectedRows[0].Cells["Author"].Value.ToString();
                title = DGV_ShowTestsOfGroup.SelectedRows[0].Cells["Title"].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There are no tests", "Server Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var testId = repoTest.FirstOrDefault(t => t.Author == author && t.Title == title).Id;

            var res = repoGroupTest.FindAll(t => t.TestId == testId).ToList();
            foreach (var t in res)
            {
                repoGroupTest.Remove(t);
            }

            var bs = from g in repoGroup.GetAllData()
                     join gt in repoGroupTest.GetAllData() on g.Id equals gt.GroupId
                     join t in repoTest.GetAllData() on gt.TestId equals t.Id
                     where g.Id == groupId
                     select new { GroupName = g.Name, Author = t.Author, Title = t.Title, NumOfQuestions = t.NumOfQuestions, Time = t.Time };

            DGV_ShowTestsOfGroup.DataSource = bs.ToList();

        }
    }




}
