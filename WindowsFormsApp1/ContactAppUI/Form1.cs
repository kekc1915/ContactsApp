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
        
        }
        private List<Contact> _contactsListMainForm = new List<Contact>();

        private static  string _text;

        public static string  TxtBox
        {

            get { return _text; }
            set { _text = value; }

        }

        private static Contact _newContactForm1;

        public static Contact newContactForm1
        {
            get { return _newContactForm1; }
            set { _newContactForm1 = value; }
        }
        

        private void AddButton_Click(object sender, EventArgs e)
        {
            newContactForm1 = null;
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
            if (newContactForm1 != null)
            {
                _contactsListMainForm.Add(newContactForm1);
                ContactsListBox.Items.Add(_text);
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
       
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
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
                newContactForm1 = _contactsListMainForm[ContactsListBox.SelectedIndex];
                NameTextBox.Text = _contactsListMainForm[ContactsListBox.SelectedIndex].Name;
                SurnameTextBox.Text = _contactsListMainForm[ContactsListBox.SelectedIndex].Surname;
                EmailTextBox.Text = _contactsListMainForm[ContactsListBox.SelectedIndex].email;
                VkTextBox.Text = _contactsListMainForm[ContactsListBox.SelectedIndex].idvk;
                BirthdayDateTimePicker.Value = _contactsListMainForm[ContactsListBox.SelectedIndex].Birthday;
                PhoneTextBox.Text= Convert.ToString(_contactsListMainForm[ContactsListBox.SelectedIndex].Phone.Number);
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

        private void FixButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (ContactsListBox.SelectedIndex >=0)
            {
                Form2.newContacts = _contactsListMainForm[ContactsListBox.SelectedIndex];
                _contactsListMainForm.RemoveAt(ContactsListBox.SelectedIndex);
                ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                form2.ShowDialog();
                _contactsListMainForm.Add(newContactForm1);
                ContactsListBox.Items.Add(_text);
            }
        }
        
        private void RemoveButton_Click(object sender, EventArgs e)
        {

           DialogResult result=MessageBox.Show("Do you really want to delete the contact?", "Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if ( result==DialogResult.OK)
            {
                _contactsListMainForm.RemoveAt(ContactsListBox.SelectedIndex);
                ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
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
            FixButton_Click(null, null);
        }

        private void RemoveContactToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RemoveButton_Click(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
