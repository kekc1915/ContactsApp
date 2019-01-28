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
            public string UppercaseFirst(string s)
            {
                char[] a = s.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }

            /// <summary>
            /// Переменная для реализации метода get в Name
            /// </summary>
            private string _name;

            /// <summary>
            /// Имя контакта
            /// </summary>
            public string Name
            {
                get
                {
                    return (UppercaseFirst(_name));
                }

                set
                {
                    if (value.Length > 50 || value == String.Empty)
                    {
                        throw new ArgumentException(@"Имя должна быть короче 50 символов и не пустой строкой");
                    }
                    else _name = value;
                }
            }

            /// <summary>
            /// Переменная для реализации метода get в Surname
            /// </summary>
            private string _surname;

            /// <summary>
            /// Фамилия контакта
            /// </summary>
            public string Surname
            {
                get { return UppercaseFirst(_surname); }
                set
                {
                    if (value.Length > 50 || value == String.Empty)
                    {
                        throw new ArgumentException(@"Фамилия должна быть короче 50 символов и не пустой строкой");
                    }
                    else _surname = value;
                }
            }

            /// <summary>
            /// Переменная для реализации метода get в email
            /// </summary>
            private string _email;

            /// <summary>
            /// Адрес электронной почты контакта
            /// </summary>
            public string Email
            {
                get
                {
                    return _email;
                }
                set
                {
                    if (value.Length > 50)
                    {
                        throw new ArgumentException(@"Email должен быть короче 50 символов ");
                    }
                    else _email = value;
                }
            }
            /// <summary>
            /// Переменная для реализации метода get в idvk
            /// </summary>
            private string _idvk;

            /// <summary>
            /// ID страницы ВКонтакте контакта
            /// </summary>
            public string Idvk
            {
                get
                {
                    return _idvk;
                }
                set
                {
                    if (value.Length > 15 )
                    {
                        throw new ArgumentException(@"Ид ВКонтакте должен быть короче 15 символов");
                    }
                    else _idvk = value;
                }
            }
            /// <summary>
            /// Переменная для реализации метода get в Date
            /// </summary>
            private DateTime _checkDate;

            /// <summary>
            /// Минимальная дата которая может быть назначена в качестве даты рождения
            /// </summary>
            //private readonly DateTime _dateMin = new DateTime(1900, 01, 01);

            /// <summary>
            /// Дата рождения контакта
            /// </summary>
            public DateTime Birthday
            {
                get { return _checkDate; }
            set
            {
                DateTime _dateMin = new DateTime(1900, 01, 01);
                if (value >= DateTime.Now.AddDays(1) || value < _dateMin)
                    {
                        throw new ArgumentException("Дата рождения должна быть меньше текущей даты и более чем 1900 год");
                    }
                    else _checkDate = value;
                }

            }
            /// <summary>
            /// Переменная для реализации метода get в Phone
            /// </summary>
            private PhoneNumber _phone;

            /// <summary>
            /// Переменная,связанная с классом Numbers, хранящая данные о номере телефона
            /// </summary>
            public PhoneNumber Phone
            {
                get { return _phone; }
                set { _phone = value; }
            }

        }
    }

