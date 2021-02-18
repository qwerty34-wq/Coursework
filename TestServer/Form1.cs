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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class Form1 : Form
    {
        static GenericUnitOfWork work = new GenericUnitOfWork(new Context(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
        IGenericRepository<User> repoUser = work.Repository<User>();
        IGenericRepository<Group> repoGroup = work.Repository<Group>();
        IGenericRepository<Test> repoTest = work.Repository<Test>();
        IGenericRepository<Grade> repoGrade = work.Repository<Grade>();

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
            //var bs = repoUser.GetAllData().Select(p => new { p.Id, p.FName, p.LName, p.Login, p.Password, p.IsAdmin }).ToList();

            //var bs = repoUser.GetAllData().ToList();

            //var bs = from b in repoUser.GetAllData()
            //         join s in repoGroup.GetAllData() on b.GroupId equals s.Id
            //         select new { UserId = b.Id, FirstName = b.FName, LastName = b.LName, UserLogin = b.Login, UserPassword = b.Password, Admin = b.IsAdmin, Group = s.Name };

            //bs = bs.ToList();

            //List<object> list = new List<object>();

            //foreach (var user in repoUser.GetAllData())
            //{
            //    if (user.GroupId == null)
            //    {
            //        list.Add(new
            //        {
            //            UserId = user.Id,
            //            FirstName = user.FName,
            //            LastName = user.LName,
            //            UserLogin = user.Login,
            //            UserPassword = user.Password,
            //            Admin = user.IsAdmin
            //        });
            //        continue;
            //    }
            //    else
            //    {
            //        var group = repoGroup.FindById(user.GroupId);

            //        list.Add(new
            //        {
            //            UserId = user.Id,
            //            FirstName = user.FName,
            //            LastName = user.LName,
            //            UserLogin = user.Login,
            //            UserPassword = user.Password,
            //            Admin = user.IsAdmin,
            //            Group = group.Name
            //        });
            //    }


            //}

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

            //var groups = repoGroup.GetAllData().ToList();
            //foreach (var item in collection)
            //{

            //}
        }
        private void ShowUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[4];
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
        }
        private void AsignesTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[10];
        }
        private void ShowTestsOfGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[11];
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
    }
}
