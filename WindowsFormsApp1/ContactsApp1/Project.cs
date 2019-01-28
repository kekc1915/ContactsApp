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

        /// <summary>
        /// Функция вычисляющая если ли среди списка контактов те,у которых день и месяц рождения сопадает с текущим
        /// </summary>
        /// <param name="_dateTimeNow">Параметр передающий текущую дату</param>
        /// <param name="_contactsList">Параметр списка контактов</param>
        /// <returns>Если есть сопадения,то возвращает список именниников,если нет то null</returns>
        public List<Contact> HappyBirthdayInfo(DateTime _dateTimeNow,List<Contact> _contactsList)
        {
            List<Contact> _contactsListResult = new List<Contact>();
            int j = 0;
            for (int i = 0; i < _contactsList.Count; i++)
            {
               if( _contactsList[i].Birthday.Day==_dateTimeNow.Day && _contactsList[i].Birthday.Month == _dateTimeNow.Month)
                {
                    _contactsListResult.Add(_contactsList[i]);
                    j++;
                }
            }
            if (j != 0)
                return _contactsListResult;
            else return null;
        }
        
        /// <summary>
        /// Функция выполняющая сортировку переданного списка контактов по алфавиту
        /// </summary>
        /// <param name="_contactList">Список контактов для сортировки</param>
        /// <returns></returns>
        public List<Contact> Sort(List<Contact> _contactList)
        {
                _contactList.Sort(delegate (Contact _contactOne, Contact _contactTwo)
                { return _contactOne.Surname.CompareTo(_contactTwo.Surname); });
                return _contactList;
        }

        /// <summary>
        /// Функция выполняющая сортировку контактов по алфавиту,если в списке контактов
        /// присуствует подстрока
        /// </summary>
        /// <param name="ContactListSort">Список контактов для сортировки</param>
        /// <param name="findString">Подстрока для поиска среди имени или фамилии контактов</param>
        /// <returns></returns>
        public List<Contact> Sort(List<Contact> _contactList, string _findString)
        {
            List<Contact> _resultContactList = new List<Contact>();
            for (int i = 0; i < _contactList.Count; i++)
            {
                if (_contactList[i].Surname.Contains(_findString) == true || _contactList[i].Name.Contains(_findString) == true)
                {
                    _resultContactList.Add(_contactList[i]);
                }
            }

            return Sort(_resultContactList);
        }
    }
}
