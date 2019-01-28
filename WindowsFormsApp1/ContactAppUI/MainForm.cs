using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.Deserialization(null);
            if(_project!=null)
            {
               for(int i=0;i<_project.ContactList.Count;i++)
                {
                    ContactsListBox.Items.Add(_project.ContactList[i].Surname);
                }
            }
            BirthdayDateTimePicker.MaxDate = DateTime.Now;
            if (_project.HappyBirthdayInfo(DateTime.Now, _project.ContactList) != null)
            {
                Project _projectHappyBirthday = new Project();
                _projectHappyBirthday.ContactList = _project.HappyBirthdayInfo(DateTime.Now, _project.ContactList);
                string _stringBirthday = "";
                for (int i = 0; i < _projectHappyBirthday.ContactList.Count; i++)
                {
                    _stringBirthday = _stringBirthday + _projectHappyBirthday.ContactList[i].Surname + " ";
                }
                HappyBirthdayLabel.Text = "Сегодня день рождения: \n" + _stringBirthday;
            }
            else HappyBirthdayLabel.Text = "";
        }

        private Project _project=new Project();

        private void AddButton_Click(object sender, EventArgs e)
        {         
            var _addForm = new AddEditForm();
            _addForm.newContact.Phone = null;
            _addForm.ShowDialog();
            var _updatedDate = _addForm.newContact;         
            if (_updatedDate != null)
            {
                if (FindTextBox.Text != string.Empty)
                {
                    _project = ProjectManager.Deserialization(null);
                }
                _project.ContactList.Add(_updatedDate);
                ContactsListBox.Items.Add(_updatedDate.Surname);
                _project.Sort(_project.ContactList);
                ContactsListBox.Sorted = true;
                _project.ContactList = _project.Sort(_project.ContactList);
                ProjectManager.Serialization(_project,null);
                if (FindTextBox.Text != string.Empty)
                {
                    FindFunction();
                }
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
       
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddEditForm _addEditForm = new AddEditForm();
            if (ContactsListBox.SelectedIndex >= 0)
            {
                _addEditForm.newContact = _project.ContactList[ContactsListBox.SelectedIndex];
                _addEditForm.ShowDialog();
                if (_addEditForm.newContact != null)
                {
                    var _updatedDate = _addEditForm.newContact;
                    if (FindTextBox.Text != string.Empty)
                    {
                        FindIndex();
                        _project = ProjectManager.Deserialization(null);
                    }
                    else
                    {
                        _project.ContactList.RemoveAt(ContactsListBox.SelectedIndex);
                    }
                    ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                    _project.ContactList.Add(_updatedDate);
                    ContactsListBox.Items.Add(_updatedDate.Surname);
                    ContactsListBox.Sorted = true;
                    _project.Sort(_project.ContactList);
                    ProjectManager.Serialization(_project,null);
                    NameTextBox.Text = _updatedDate.Name;
                    SurnameTextBox.Text = _updatedDate.Surname;
                    EmailTextBox.Text = _updatedDate.Email;
                    VkTextBox.Text = _updatedDate.Idvk;
                    BirthdayDateTimePicker.Value = _updatedDate.Birthday;
                    PhoneTextBox.Text = Convert.ToString(_updatedDate.Phone.Number);
                    if (FindTextBox.Text != string.Empty)
                    {
                        FindFunction();
                    }
                }
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            
        }

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void SelectedIndex()
        {

        }
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex >= 0)
            {
                Contact newContact; 
                newContact = _project.ContactList[ContactsListBox.SelectedIndex];
                NameTextBox.Text = newContact.Name;
                SurnameTextBox.Text = newContact.Surname;
                EmailTextBox.Text = newContact.Email;
                VkTextBox.Text = newContact.Idvk;
                BirthdayDateTimePicker.Value = newContact.Birthday;
                PhoneTextBox.Text = Convert.ToString(newContact.Phone.Number);   
            }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindIndex()
        {
            Project _projectFindIndex =ProjectManager.Deserialization(null);
            for(int i=0; i< ContactsListBox.Items.Count; i++)
                for(int j = 0; j < _projectFindIndex.ContactList.Count; j++)
                {
                    if (Convert.ToString(ContactsListBox.Items[i]) == _projectFindIndex.ContactList[j].Surname)
                    {
                        _projectFindIndex.ContactList.RemoveAt(j);
                        ProjectManager.Serialization(_projectFindIndex, null);
                    }
                }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you really want to delete the contact?\n" 
                    + _project.ContactList[ContactsListBox.SelectedIndex].Surname + " " 
                    + _project.ContactList[ContactsListBox.SelectedIndex].Name, 
                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    if(FindTextBox.Text != string.Empty)
                    {
                        FindIndex();
                        _project = ProjectManager.Deserialization(null);
                    }
                    else
                    {
                        _project.ContactList.RemoveAt(ContactsListBox.SelectedIndex);
                    }
                    ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                    ProjectManager.Serialization(_project,null);
                    NameTextBox.Clear();
                    SurnameTextBox.Clear();
                    EmailTextBox.Clear();
                    PhoneTextBox.Clear();
                    VkTextBox.Clear();
                    BirthdayDateTimePicker.Value = BirthdayDateTimePicker.MaxDate;
                    if (FindTextBox.Text != string.Empty)
                    {
                        FindFunction();
                    }
                }
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AddContactToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddButton_Click(null, null);
        }

        private void EditContactToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditButton_Click(null, null);
        }

        private void RemoveContactToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RemoveButton_Click(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            ProjectManager.Serialization(_project,null);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm _aboutForm = new AboutForm();
            _aboutForm.ShowDialog();
        }

        private void FindFunction()
        {
            if (FindTextBox.Text != string.Empty)
            {
                ContactsListBox.Items.Clear();
                _project.ContactList = _project.Sort(_project.ContactList, FindTextBox.Text);
            }
            else
            {
                ContactsListBox.Items.Clear();
                _project = ProjectManager.Deserialization(null);
            }
            for (int i = 0; i < _project.ContactList.Count; i++)
            {
                ContactsListBox.Items.Add(_project.ContactList[i].Surname);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            _project = ProjectManager.Deserialization(null);
            FindFunction();
        }

        private void HappyBirthdayLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
