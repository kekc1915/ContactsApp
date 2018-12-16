using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
        /// <summary>
        /// Класс хранящий данные о номерe телефона.
        /// </summary>
        public class Numbers
        {
            /// <summary>
            /// Переменная для реализации метода get в Number
            /// </summary>
            private System.Int64 _numbercheck;

            /// <summary>
            /// Переменная,аналог longint,хранящая данная о номере телефона и выполняющая все необходимые проверки
            /// </summary>
            public System.Int64 Number
            {
                get { return _numbercheck; }
                set
                {
                    if (value > 79999999999 && value < 70000000000)
                    {
                        throw new ArgumentException("Номер телефона должен быть в формате 7xxxxxxxxxx,а был " + value);
                    }
                    else _numbercheck = value;
                }
            }
        }
    }

