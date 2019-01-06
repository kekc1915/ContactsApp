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
            _project = Project_Manager.Deserialization(_project);
            if(_project!=null)
            {
               for(int i=0;i<_project.ContactList.Count;i++)
                {
                    ContactsListBox.Items.Add(_project.ContactList[i].Surname);
                }
            }

            Project _projectHappyBirthday = new Project();

            _projectHappyBirthday.ContactList=_project.HappyBirthdayInfo(DateTime.Now, _project.ContactList);
            if (_projectHappyBirthday != null)
            {
                string _stringBirthday = "";
                for (int i = 0; i < _projectHappyBirthday.ContactList.Count; i++)
                {
                    _stringBirthday =  _stringBirthday + _projectHappyBirthday.ContactList[i].Surname + " ";
                }
                HappyBirthdayLabel.Text = "Сегодня день рождения: \n"+_stringBirthday;
            }
        }

        public void Sort()
        {
            ContactsListBox.Sorted = true;
            if (_project != null)
            {
                Project sortProject=new Project();
                sortProject = _project;
                for (int i = 0; i < _project.ContactList.Count; i++)
                {
                    if (ContactsListBox.Items[i].ToString() != _project.ContactList[i].Surname)
                    {
                        for (int j = 0; j < sortProject.ContactList.Count; j++)
                        {
                            if (sortProject.ContactList[j].Surname == ContactsListBox.Items[i].ToString())
                            {
                                _project.ContactList[j] = sortProject.ContactList[i];
                                _project.ContactList[i] = sortProject.ContactList[j];
                            }
                        }


                    }
                }
            }
        }

        private Project _project=new Project();

        private void AddButton_Click(object sender, EventArgs e)
        {         
            var form2 = new AddEditForm();
            form2.newContact.Phone = null;
            form2.ShowDialog();
            var UpdatedDate = form2.newContact;         
            if (UpdatedDate != null)
            {
                _project.ContactList.Add(UpdatedDate);
                ContactsListBox.Items.Add(UpdatedDate.Surname);
               // Sort();
                Project_Manager.Serialization(_project);
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
       
        }
        private int IfFindTextBoxNoEmpty(int index)
        {
            for (int i = 0; i < _project.ContactList.Count; i++)
            {
                if (_project.ContactList[i] == _searchString.ContactList[ContactsListBox.SelectedIndex])
                    index = i;
            }
            return index;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            AddEditForm form2 = new AddEditForm();
            if (ContactsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = ContactsListBox.SelectedIndex;
                if (FindTextBox.Text != string.Empty)
                {
                    selectedIndex = IfFindTextBoxNoEmpty(selectedIndex);
                }
                form2.newContact = _project.ContactList[selectedIndex];
                form2.ShowDialog();
                if (form2.newContact != null)
                {
                    var UpdatedDate = form2.newContact;
                    _project.ContactList.RemoveAt(selectedIndex);
                    ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                    _project.ContactList.Add(UpdatedDate);
                    ContactsListBox.Items.Add(UpdatedDate.Surname);
                   // Sort();
                    Project_Manager.Serialization(_project);
                    NameTextBox.Text = UpdatedDate.Name;
                    SurnameTextBox.Text = UpdatedDate.Surname;
                    EmailTextBox.Text = UpdatedDate.Email;
                    VkTextBox.Text = UpdatedDate.Idvk;
                    BirthdayDateTimePicker.Value = UpdatedDate.Birthday;
                    PhoneTextBox.Text = Convert.ToString(UpdatedDate.Phone.Number);
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
                if (FindTextBox.Text != string.Empty)
                {
                    newContact = _searchString.ContactList[ContactsListBox.SelectedIndex];
                }
                else
                {
                    newContact = _project.ContactList[ContactsListBox.SelectedIndex];
                }
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = ContactsListBox.SelectedIndex;
                if (FindTextBox.Text != string.Empty)
                {
                    selectedIndex = IfFindTextBoxNoEmpty(selectedIndex);
                }

                DialogResult result = MessageBox.Show("Do you really want to delete the contact?\n" + _project.ContactList[selectedIndex].Surname + " " + _project.ContactList[selectedIndex].Name, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    if (FindTextBox.Text != string.Empty)
                    {
                        _searchString.ContactList.RemoveAt(ContactsListBox.SelectedIndex);
                        ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                        _project.ContactList.RemoveAt(selectedIndex);
                    }
                    else
                    {
                        _project.ContactList.RemoveAt(ContactsListBox.SelectedIndex);
                        ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                    }
                    Project_Manager.Serialization(_project);
                    NameTextBox.Clear();
                    SurnameTextBox.Clear();
                    EmailTextBox.Clear();
                    PhoneTextBox.Clear();
                    VkTextBox.Clear();
                    BirthdayDateTimePicker.Value = BirthdayDateTimePicker.MaxDate;
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
            Project_Manager.Serialization(_project);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private Project _searchString = new Project();

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if( FindTextBox.Text != string.Empty)
            {
                
                ContactsListBox.Items.Clear();
                for(int i = 0; i < _project.ContactList.Count; i++)
                {
                   // ContactsListBox.Items[i].ToString().Contains(FindTextBox.Text) == true
                    if (_project.ContactList[i].Surname.Contains(FindTextBox.Text) == true || _project.ContactList[i].Name.Contains(FindTextBox.Text)==true)
                    {
                       _searchString.ContactList.Add(_project.ContactList[i]);
                        ContactsListBox.Items.Add(_project.ContactList[i].Surname);
                    }
                }  
            }
            else
            {
                ContactsListBox.Items.Clear();
                _searchString.ContactList.Clear();
                for (int i = 0; i < _project.ContactList.Count; i++)
                ContactsListBox.Items.Add(_project.ContactList[i].Surname);
            }
        }

        private void HappyBirthdayLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
