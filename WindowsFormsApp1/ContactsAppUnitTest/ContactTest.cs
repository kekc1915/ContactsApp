using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactsApp;
using NUnit.Framework;

namespace ContactsAppUnitTest
{

    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;
        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }
        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если фамилия длиннее 50 символов",
            TestName = "Присвоение неправильной фамилии больше 50 символов")]
        public void TestSurnameSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Surname = wrongSurname; },
            message);
        }
        [TestCase("Родичев","Тест пройден если иключений не возникло",
            TestName = "Присвоение правильной фамилии")]
        public void TestSurnameSet_CorrectValue(string rightSurname, string message)
        {
            Assert.DoesNotThrow(
            () => { _contact.Surname = rightSurname; },
            message);
        }
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.Surname = expected;
            var actual = _contact.Surname;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }

        [TestCase("", "Должно возникать исключение, если имя - пустая строка",
            TestName = "Присвоение пустой строки в качестве имени")]
        [TestCase("-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя-Имя", "Должно возникать исключение, если имя длиннее 50 символов",
            TestName = "Присвоение неправильной имени больше 50 символов")]
        public void TestNameSet_ArgumentException(string wrongName, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Name = wrongName; },
            message);
        }
        [TestCase("Артем", "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного имени")]
        public void TestNameSet_CorrectValue(string right, string massage)
        {
            Assert.DoesNotThrow(
            () => { _contact.Name = right; },
            massage);
        }
        [Test(Description = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Иван";
            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }
        [TestCase("", "Должно возникать исключение, если Email - пустая строка",
            TestName = "Присвоение пустой строки в качестве Email")]
        [TestCase("-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email-Email", "Должно возникать исключение, если Email длиннее 50 символов",
            TestName = "Присвоение неправильной Email больше 50 символов")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Email = wrongEmail; },
            message);
        }
        [Test(Description = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "rodichevartem@yandex.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный Email");
        }
        [TestCase("rodichevartem@yandex.ru", "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного email")]
        public void TestEmailSet_CorrectValue(string right, string massage)
        {
            Assert.DoesNotThrow(
            () => { _contact.Email = right; },
            massage);
        }
        [TestCase("", "Должно возникать исключение, если Idvk - пустая строка",
            TestName = "Присвоение пустой строки в качестве Idvk")]
        [TestCase("-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk-Idvk", "Должно возникать исключение, если Idvk длиннее 15 символов",
            TestName = "Присвоение неправильной Idvk больше 50 символов")]
        public void TestIdvkSet_ArgumentException(string wrongIdvk, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Idvk = wrongIdvk; },
            message);
        }
        [Test(Description = "Позитивный тест геттера Idvk")]
        public void TestIdvkGet_CorrectValue()
        {
            var expected = "id128983891";
            _contact.Idvk = expected;
            var actual = _contact.Idvk;
            Assert.AreEqual(expected, actual, "Геттер Idvk возвращает неправильный id");
        }
        [TestCase("artem_rodichev", "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного id")]
        public void TestIdvkSet_CorrectValue(string right, string massage)
        {
            Assert.DoesNotThrow(
            () => { _contact.Idvk = right; },
            massage);
        }
         [TestCase("01.01.1800 0:00:00", "Должно возникать исключение, если дата меньше 1900 ",
         TestName = "Присвоение даты меньше минимальной в качестве Birthday")]
         [TestCase("01.01.2050 0:00:00", "Должно возникать исключение, если дата больше текущей",
         TestName = "Присвоение даты большей текущей")]
         public void TestBirthdaySet_ArgumentException(string wrongDateString, string message)
         {
            DateTime wrongDate = Convert.ToDateTime(wrongDateString);
            Assert.Throws<ArgumentException>(
            () => { _contact.Birthday = wrongDate; },
            message);
         }
       /* [Test(Description = "Позитивный тест геттера Birthday")]
        public void TestBirthdayGet_CorrectValue()
        {
            DateTime expected = new DateTime(1998,09,08);
            _contact.Birthday = expected;
            var actual = _contact.Birthday;
            Assert.AreEqual(expected, actual, "Геттер Phone возвращает неправильный номер");
        }*/
        [TestCase("18.12.2018 0:00:00", "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного Birthday")]
        public void TestBirthdaySet_CorrectValue(string rightString, string massage)
        {
            DateTime right = Convert.ToDateTime(rightString);
            Assert.DoesNotThrow(
            () => { _contact.Birthday = right; },
            massage);
        }

       
        [Test(Description = "Позитивный тест геттера Phone")]
        public void TestPhoneGet_CorrectValue()
        {
            Numbers expected = new Numbers();
            _contact.Phone = expected;
            var actual = _contact.Phone;
            Assert.AreEqual(expected, actual, "Геттер Phone возвращает неправильный номер");
        }
       /* [TestCase("Артем", "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного имени")]
        public void TestNameSet_CorrectValue(string right, string massage)
        {
            Assert.DoesNotThrow(
            () => { _contact.Name = right; },
            massage);
        }*/
    }
   
}

        

