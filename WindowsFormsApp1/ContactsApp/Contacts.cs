using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс,содержащий информацию о имене,фамилии,email,ID ВКонтакте и дате рождения
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Метод преобразующий первую буквы в строке к верхнему регистру 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string UppercaseFirst(char[] s)
        {
            s[0] = char.ToUpper(s[0]);
            return new string(s);
        }

        /// <summary>
        /// 
        /// </summary>
        private char[] _name = new char[50];

        /// <summary>
        /// 
        /// </summary>
        public string name
        {
            get { return new string(_name); }
            set
            {
                name = UppercaseFirst(_name);
            }
        }

        private char[] _surname = new char[50];

        public string surnameOfPerson
        {
            get { return new string(_surname); }
            set
            {

                surnameOfPerson = UppercaseFirst(_surname);
            }
        }
        public char[] email = new char[50];
        public char[] idvkontakte = new char[15];
        private DateTime _checkDate;
        //private DateTime dateTimeNow = DateTime.Now;
        private readonly DateTime dateMin = new DateTime(1900, 00, 00);
        public DateTime dateOfBirth
        {
            get { return _checkDate; }
            set
            {
                if (_checkDate > DateTime.Now && _checkDate < dateMin)
                {
                    throw new ArgumentException("Дата рождения должна быть меньше текущей даты и более чем 1900 год");
                }
                else dateOfBirth = _checkDate;
            }

        }
        private NumberOfPhone _phone;
        public NumberOfPhone phone
        {
            get { return _phone; }
            set { phone = _phone; }
        }

    }
}
