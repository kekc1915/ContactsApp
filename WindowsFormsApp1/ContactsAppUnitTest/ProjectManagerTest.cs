using System;
using System.IO;
using ContactsApp;
using NUnit.Framework;
using Newtonsoft.Json;

namespace ContactsAppUnitTest
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Project _project = new Project();
        private Contact _contact = new Contact();
        [SetUp]
        public void InitComponent()
        {
            _contact.Name = "Ivan";
            _contact.Surname = "Ivanov";
            _contact.Birthday = new DateTime(1998, 09, 08);
            _contact.Email = "ivanov@yandex.ru";
            _contact.Idvk = "1234542";
            _contact.Phone.Number = 79132662020;
        }

        [Test(Description = "Позитивный тест сериализации")]
        public void TestSerialization_CorrectValue()
        {
            _project.ContactList.Add(_contact);

            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestSerialize.notes";
            var fileReference = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestSerializeReference.notes";

            ProjectManager.Serialization(_project, filePath);

            var referenceProjectString = File.ReadAllText(fileReference);
            var actualProjectString = File.ReadAllText(filePath);

            Assert.AreEqual(referenceProjectString, actualProjectString,
                "Тест сериализации не пройден.");
        }

        [Test(Description = "Позитивный тест десериализации")]
        public void TestDeserilization_CorrectValue()
        {
            Project project = new Project();
            _project.ContactList.Add(_contact);

            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestDeserialize.notes";
            var fileReference = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "/ContactsApp" + "/ContactsAppTest" + "/ContactAppTestDeserializeReference.notes";

            project = ProjectManager.Deserialization(fileReference);

            Assert.AreEqual(_project.ContactList.Count, project.ContactList.Count,
                "Десериализация работает неправильно.");
            for (int index = 0; index < _project.ContactList.Count; index++)
            {
                Assert.AreEqual(_project.ContactList[index].Surname, project.ContactList[index].Surname,
                    "Некорректная десериализация фамилии");
                Assert.AreEqual(_project.ContactList[index].Name, project.ContactList[index].Name,
                    "Некорректная десериализация имени");
                Assert.AreEqual(_project.ContactList[index].Email, project.ContactList[index].Email,
                    "Некорректная десериализация е-мейла");
                Assert.AreEqual(_project.ContactList[index].Idvk, project.ContactList[index].Idvk,
                    "Некорректная десериализация id vk");
                Assert.AreEqual(_project.ContactList[index].Phone.Number,
                    project.ContactList[index].Phone.Number,
                    "Некорректная десериализация номера телефона");
                Assert.AreEqual(_project.ContactList[index].Birthday,
                    project.ContactList[index].Birthday,
                    "Некорректная десериализация фамилии");
            }
        }
    }
}

