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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BirthdayDateTimePicker.MaxDate = DateTime.Now;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (newContacts != null)
            {
                SurnameTextBox.Text = newContacts.Surname;
                NameTextBox.Text = newContacts.Name;
                EmailTextBox.Text = newContacts.email;
                VkTextBox.Text = newContacts.idvk;
                BirthdayDateTimePicker.Value = newContacts.Birthday;
                PhoneTextBox.Text = Convert.ToString(newContacts.Phone.Number);
            }
            
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
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

        private static Contact _newContacts;

        public static  Contact newContacts
        {
            get { return _newContacts; }
            set { _newContacts = value; }
        }

       private Contact newContact = new Contact();

       private Numbers _phone = new Numbers();


        private void OkButton_Click(object sender, EventArgs e)
        {
            
            _phone.Number = System.Int64.Parse(PhoneTextBox.Text);
            newContact.Surname = SurnameTextBox.Text;
            newContact.Name = NameTextBox.Text;
            newContact.Birthday = BirthdayDateTimePicker.Value;
            newContact.Phone = _phone;
            newContact.email = EmailTextBox.Text;
            newContact.idvk = VkTextBox.Text;  
            Form1.TxtBox = newContact.Surname;
            Form1.newContactForm1 = newContact;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                Form1.newContactForm1 = null;
                newContacts = null;
            }
            this.Close();
        }
    }
}
