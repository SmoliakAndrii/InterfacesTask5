using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
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
        public static void printArray(List<Contact> arr)
        {
            for (int i = 0; i < arr.Count; i++)
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
            arr[3] = new PhoneContact("vasyl", 234002340);
            arr[4] = new PhoneContact("oleg", 324823487);
            showInformationByName("marian", arr);
            showInformationByName("petro", arr);

            var sortedArray = arr.OrderBy(x => x.name).ToList();

            Array.Sort(arr,ContactComparator);
            printArray(sortedArray);
            Console.Read();
        }
    }
}
