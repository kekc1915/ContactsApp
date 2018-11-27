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
        private System.Int64 _numbercheck;

        public System.Int64 number
        {
            get { return _numbercheck; }
            set
            {
                if (_numbercheck > 79999999999 && _numbercheck < 70000000000)
                {
                    throw new ArgumentException("Номер телефона должен быть в формате 7xxxxxxxxxx,а был " + _numbercheck);
                }
                else number = _numbercheck;
            }

        }
    }
}
