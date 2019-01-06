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
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
            BirthdayDateTimePicker.MaxDate = DateTime.Now;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           if (newContact.Phone != null)
            {
                SurnameTextBox.Text = newContact.Surname;
                NameTextBox.Text = newContact.Name;
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

        
        public Contact newContact
        {
            get
            {
                return _newContact;
            }
            set
            {
                _newContact = value;
            }
        }
        private Contact _newContact = new Contact();
      
        
       // private Contact newContact = new Contact();

        private Numbers _phone = new Numbers();

        private void OkButton_Click(object sender, EventArgs e)
        {
            
            _phone.Number = System.Int64.Parse(PhoneTextBox.Text);
            newContact.Surname = SurnameTextBox.Text;
            newContact.Name = NameTextBox.Text;
            newContact.Birthday = BirthdayDateTimePicker.Value;
            newContact.Phone = _phone;
            newContact.Email = EmailTextBox.Text;
            newContact.Idvk = VkTextBox.Text;
           /* _data.TxtBox = newContact.Surname;
            _data.newContact = newContact;*/
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           /* MainForm main = this.Owner as MainForm;
            var form1 = new MainForm();
            if (main != null)
            {*/
                newContact = null;
           // }
            this.Close();
        }
    }
}
