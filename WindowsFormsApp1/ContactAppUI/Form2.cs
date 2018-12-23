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
           if (Data.newContact != null)
            {
                SurnameTextBox.Text = Data.newContact.Surname;
                NameTextBox.Text = Data.newContact.Name;
                EmailTextBox.Text = Data.newContact.Email;
                VkTextBox.Text = Data.newContact.Idvk;
                BirthdayDateTimePicker.Value = Data.newContact.Birthday;
                PhoneTextBox.Text = Convert.ToString(Data.newContact.Phone.Number);
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

        public class DataInMainForm
        {
            public string TxtBox;
            public Contact newContact;
        }
        private DataInMainForm _data = new DataInMainForm();
        public DataInMainForm Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
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
            newContact.Email = EmailTextBox.Text;
            newContact.Idvk = VkTextBox.Text;
            _data.TxtBox = newContact.Surname;
            _data.newContact = newContact;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            var form1 = new Form1();
            if (main != null)
            {
                Data = null;
            }
            this.Close();
        }
    }
}
