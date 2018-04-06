using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        public static void showInformationByName(string Name,Contact[]arr)
        {
            foreach(Contact findContact in arr)
            {
                if(Name.Equals(findContact.name))
                {
                    findContact.Print();
                    return;
                }
            }
            Console.WriteLine("There is no contact with this name");
        }

        public static int ContactComparator(Contact con1,Contact con2)
        {
            return String.Compare(con1.name, con2.name);
        }
        public static void printArray(Contact[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Print();
            }
        }
        static void Main(string[] args)
        {
            Contact[] arr = new Contact[5];
            arr[0] = new MailContact("andrew", "andrgmailcom");
            arr[1] = new MailContact("bodya", "bodgmailcom");
            arr[2] = new MailContact("marian", "mariangmailcom");
            arr[3] = new PhoneContact("lox", 234002340);
            arr[4] = new PhoneContact("debil", 324823487);
            showInformationByName("debil", arr);
            showInformationByName("daun", arr);

            Array.Sort(arr,ContactComparator);
            printArray(arr);
            Console.Read();
        }
    }
}
