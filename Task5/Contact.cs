using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    abstract class Contact:IContact
    {
        public string name { get; set; }
        public abstract void Input();
        public abstract void Print();
    }
}
