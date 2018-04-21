using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;

namespace UnitTestTask5
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void MailComparator()
        {
            MailContact contact1 = new MailContact("Andrew", "andrew@");
            MailContact contact2 = new MailContact("Bodya", "Bodya@");
            int expected = 1;

            int result = contact1.CompareTo(contact2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PhoneComparator()
        {
            PhoneContact contact1 = new PhoneContact("Oleg", 22345);
            PhoneContact contact2 = new PhoneContact("Wasyl", 12345);
            int expected = 1;

            int result = contact1.CompareTo(contact2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MailContactEquels()
        {
            MailContact contact1 = new MailContact("Oleg", "oleg@mail");

            object result = contact1.Clone();
            MailContact actual = (MailContact)result;

            Assert.AreEqual(contact1.name, actual.name);
        }

        [TestMethod]
        public void PhoneContactEquels()
        {
            PhoneContact contact1 = new PhoneContact("Oleg", 12345);

            object result = contact1.Clone();
            PhoneContact actual = (PhoneContact)result;

            Assert.AreEqual(contact1.name, actual.name);
        }

        [TestMethod]
        public void sortList()
        {
            Contact[] arr = new Contact[5];
            arr[0] = new MailContact("bodya", "andrgmailcom");
            arr[1] = new MailContact("andrew", "bodgmailcom");
            arr[2] = new MailContact("marian", "mariangmailcom");
            arr[3] = new PhoneContact("vasyl", 234002340);
            arr[4] = new PhoneContact("oleg", 324823487);

            Contact[] expected = new Contact[5];
            arr[0] = new MailContact("andrew", "andrgmailcom");
            arr[1] = new MailContact("bodya", "bodgmailcom");
            arr[2] = new MailContact("marian", "mariangmailcom");
            arr[3] = new PhoneContact("oleg", 234002340);
            arr[4] = new PhoneContact("vasyl", 324823487);

            var sortedArray = arr.OrderBy(x => x.name).ToList();
            Array.Sort(arr);

            Assert.AreEqual(expected, arr);
        }
    }
}
