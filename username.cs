using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    public class username
    {
        internal static void Display()
        {
            Console.WriteLine("Enter the  usename ");

            string username = Console.ReadLine();

            int val = username.Length;

            Console.WriteLine("The num of characters is " + val);
            if (username.Length > 3)
            {
                Console.WriteLine("hello {0}, How are you!", username);

            }
            else
            {
                Console.WriteLine("The name is not having min 3 characters ");
            }
        }
    }
}
