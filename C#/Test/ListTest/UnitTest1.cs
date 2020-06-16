using NUnit.Framework;
using Test3;
namespace ListTest
{
    public class Tests
    {
        public PhoneBookList service ;
        [SetUp]
        public void Setup()
        {
            service = new PhoneBookList();
        }

        [Test]
        public void AddPhoneTest1()
        {
            service.InsertPhone("Khoa", "123");
            Assert.IsTrue(service.contacts.Count==1);
        }
        [Test]
        public void AddPhoneTest2()
        {
            AddPhoneTest1();
            service.InsertPhone("Khoa", "123");
            Assert.IsTrue(service.contacts.Count == 1);
        }
      
        [Test]
        public void UpdatePhoneTest_1()
        {
            AddPhoneTest1();
            service.UpdatePhone("Khoa", "456");
            var contact = service.Check("Khoa");
            Assert.AreEqual("456", contact.PhoneNumber);
        }
        [Test]
        public void RemovePhoneTest_1()
        {
            AddPhoneTest1();
            service.RemovePhone("Khoa");
            var contact = service.Check("Khoa");
            Assert.IsTrue(contact == null);
        }
        [Test]
        public void RemovePhoneTest_2()
        {
            AddPhoneTest1();
            service.RemovePhone("Duy");
            var contact = service.Check("Khoa");
            Assert.IsTrue(contact != null);
        }
        [Test]
        public void SearchPhoneTest()
        {
            AddPhoneTest1();
            service.SearchPhone("Khoa");
            var contact = service.Check("Khoa");
            Assert.AreEqual("Name:Khoa, PhoneNumber: 123",contact.ToString());
        }
        [Test]
        public void SearchPhoneTest2()
        {
            AddPhoneTest1();
            service.SearchPhone("Duy");
            var contact = service.Check("Duy");
            Assert.IsTrue(contact==null);
        }
      
    }
}