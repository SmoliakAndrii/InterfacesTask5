using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class PhoneContact:Contact,IComparable,ICloneable
    {
        private int phone { get; set; }

        public PhoneContact() { }
        public PhoneContact(string _name,int _phone)
        {
            name = _name;
            phone = _phone;
        }
        public object Clone()
        {
            return new PhoneContact(this.name, this.phone);
        }

        public override void Input()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter phone:");
            phone = Int32.Parse(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine("Name:{0} , Phone:{1}",name,phone);
        }

        public int CompareTo(object obj)
        {
            PhoneContact comp = obj as PhoneContact;
            if (comp != null)
            {
                return this.phone.CompareTo(comp.phone);
            }
            else
            {
                throw new ArgumentException("Not a phone contact.");
            }
        }
    }
}
