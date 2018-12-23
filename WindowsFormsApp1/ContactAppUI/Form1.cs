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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BirthdayDateTimePicker.MaxDate = DateTime.Now;
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
        }

        private Project _project=new Project();

        private void AddButton_Click(object sender, EventArgs e)
        {         
            var form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
            var UpdatedDate = form2.Data;         
            if (UpdatedDate != null)
            {
                _project.ContactList.Add(UpdatedDate.newContact);
                ContactsListBox.Items.Add(UpdatedDate.TxtBox);
                Project_Manager.Serialization(_project);
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
       
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (ContactsListBox.SelectedIndex >= 0)
            {
                form2.Data.newContact = _project.ContactList[ContactsListBox.SelectedIndex];
                form2.Data.TxtBox = _project.ContactList[ContactsListBox.SelectedIndex].Surname;
                form2.ShowDialog();
                var UpdatedDate = form2.Data;
                _project.ContactList.RemoveAt(ContactsListBox.SelectedIndex);
                ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                _project.ContactList.Add(UpdatedDate.newContact);
                ContactsListBox.Items.Add(UpdatedDate.TxtBox);
                Project_Manager.Serialization(_project);
                NameTextBox.Text = UpdatedDate.newContact.Name;
                SurnameTextBox.Text = UpdatedDate.newContact.Surname;
                EmailTextBox.Text = UpdatedDate.newContact.Email;
                VkTextBox.Text = UpdatedDate.newContact.Idvk;
                BirthdayDateTimePicker.Value = UpdatedDate.newContact.Birthday;
                PhoneTextBox.Text = Convert.ToString(UpdatedDate.newContact.Phone.Number);
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            
        }

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
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

        
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result=MessageBox.Show("Do you really want to delete the contact?\n"+ _project.ContactList[ContactsListBox.SelectedIndex].Surname + " " + _project.ContactList[ContactsListBox.SelectedIndex].Name, "Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if ( result==DialogResult.OK)
            {
                _project.ContactList.RemoveAt(ContactsListBox.SelectedIndex);
                ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                Project_Manager.Serialization(_project);
                NameTextBox.Clear();
                SurnameTextBox.Clear();
                EmailTextBox.Clear();
                PhoneTextBox.Clear();
                VkTextBox.Clear();
                BirthdayDateTimePicker.Value = BirthdayDateTimePicker.MaxDate;
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
    }
}
