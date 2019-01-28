using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
        	/// <summary>
	/// ����� �������� ������ � �����e ��������.
	/// </summary>
        public class PhoneNumber
        {
            /// <summary>
            /// ���������� ��� ���������� ������ get � Number
            /// </summary>
            private System.Int64 _numbercheck;

            /// <summary>
            /// ����������,������ longint,�������� ������ � ������ �������� � ����������� ��� ����������� ��������
            /// </summary>
            public System.Int64 Number
            {
                get { return _numbercheck; }
                set
                {
                    if (value > 79999999999 || value < 70000000000)
                    {
                        throw new ArgumentException("����� �������� ������ ���� � ������� 7xxxxxxxxxx,� ��� " + value);
                    }
                    else _numbercheck = value;
                }
            }
        }
    }

