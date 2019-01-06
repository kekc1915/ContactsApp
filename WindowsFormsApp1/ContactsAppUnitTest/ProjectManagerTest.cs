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
        [SetUp]
        public void InitFile()
        {
            StreamReader sr = new StreamReader("ContactApp.notes");
            string referenceFile = sr.ReadToEnd();
            string filename = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ContactApp.notes";
        }
        [TestCase(, "Тест пройден если иключений не возникло",
       TestName = "Позитивный тест сериализации")]
        public void TestSurnameSet_CorrectValue(string rightSurname, string message)
       private static StreamReader _sr = new StreamReader(filename);
       {
       //string file = _sr.ReadToEnd();
       Assert.DoesNotThrow(() => { _contact.Surname = rightSurname; },message);
       }*/
    
        
    }
}
