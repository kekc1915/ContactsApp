using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;
using NUnit.Framework;

namespace ContactsAppUnitTest
{
    [TestFixture]
    public class NumbersTest
    {
        private PhoneNumber _number;
        [SetUp]
        public void InitContact()
        {
            _number = new PhoneNumber();
        }
        [TestCase(89999999999, "Должно возникать исключение, если номер больше 79999999999",
            TestName = "Присвоение номера более 79999999999 в качетве номера")]
        [TestCase(5, "Должно возникать исключение, если номер менее 79000000000",
            TestName = "Присвоение неправильного номера, менее 79000000000")]
        public void TestNumberSet_ArgumentException(System.Int64 wrongNumber, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _number.Number = wrongNumber; },
            message);
        }
        [Test(Description = "Позитивный тест геттера Number")]
        public void TestNumberGet_CorrectValue()
        {
            var expected = 79132664082;
            _number.Number = expected;
            var actual = _number.Number;
            Assert.AreEqual(expected, actual, "Геттер Number возвращает неправильный номер");
        }
        [TestCase(79132664088, "Тест пройден если иключений не возникло",
            TestName = "Присвоение правильного номера")]
        public void TestNumberSet_CorrectValue(long right, string massage)
        {
            Assert.DoesNotThrow(
            () => { _number.Number = right; },
            massage);
        }
    }
}
