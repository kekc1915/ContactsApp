using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс,хранящий в себе элемент список всех контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Переменная хранящая все себе список всех контактов
        /// </summary>
        public List<Contact> ContactList = new List<Contact>();

        public List<Contact> HappyBirthdayInfo(DateTime _dateTimeNow,List<Contact> _contactsList)
        {
            List<Contact> _contactsListResult = new List<Contact>();
            for (int i = 0; i < _contactsList.Count; i++)
            {
               if( _contactsList[i].Birthday.Day==_dateTimeNow.Day && _contactsList[i].Birthday.Month == _dateTimeNow.Month)
                {
                    _contactsListResult.Add(_contactsList[i]);
                }
            }
            return _contactsListResult;
        }
        
    }
}
