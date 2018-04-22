using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class MailContact : Contact, IComparable, ICloneable
    {
        private string mail;

        public MailContact() { }
        public MailContact(string _name, string _mail)
        {
            name = _name;
            mail = _mail;
        }
        public object Clone()
        {
            return new MailContact(this.name, this.mail);
        }

        public override void Input()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter mail:");
            mail = Console.ReadLine();
        }
        public override void Print()
        {
            Console.WriteLine("Name:{0} , Mail:{1}", name, mail);
        }

        public int CompareTo(object obj)
        {
            MailContact comp = obj as MailContact;
            if (comp != null)
            {
                return string.Compare(mail, comp.mail);
            }
            else
            {
                throw new ArgumentException("Not a mail contact.");
            }
        }
    }
}
