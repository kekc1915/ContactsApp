using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    	/// <summary>
	/// �����,�������� � ���� ������� ������ ���� ���������
	/// </summary>
    public class Project
    {
        /// <summary>
        /// ���������� �������� ��� ���� ������ ���� ���������
        /// </summary>
        public List<Contact> ContactList = new List<Contact>();

        /// <summary>
        /// ������� ����������� ���� �� ����� ������ ��������� ��,� ������� ���� � ����� �������� �������� � �������
        /// </summary>
        /// <param name="_dateTimeNow">�������� ���������� ������� ����</param>
        /// <param name="_contactsList">�������� ������ ���������</param>
        /// <returns>���� ���� ���������,�� ���������� ������ �����������,���� ��� �� null</returns>
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
        /// ������� ����������� ���������� ����������� ������ ��������� �� ��������
        /// </summary>
        /// <param name="_contactList">������ ��������� ��� ����������</param>
        /// <returns></returns>
        public List<Contact> Sort(List<Contact> _contactList)
        {
                _contactList.Sort(delegate (Contact _contactOne, Contact _contactTwo)
                { return _contactOne.Surname.CompareTo(_contactTwo.Surname); });
                return _contactList;
        }

        /// <summary>
        /// ������� ����������� ���������� ��������� �� ��������,���� � ������ ���������
        /// ����������� ���������
        /// </summary>
        /// <param name="ContactListSort">������ ��������� ��� ����������</param>
        /// <param name="findString">��������� ��� ������ ����� ����� ��� ������� ���������</param>
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
