using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixAndPostFix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            

            Console.WriteLine("this is prefix");
            //prefix
            // in this situation value is increase one by one increement 
            ++i;
            Console.WriteLine(i);
            ++i;
            Console.WriteLine(i);
            ++i;
            Console.WriteLine(i);
            ++i;
            Console.WriteLine(i);
            ++i;
            Console.WriteLine(i);


            //postfix 
            // in this situation value is decrease one by one

            int j = 10;
            Console.WriteLine("this is postfix");
            
            Console.WriteLine(j--);
            j++;
            Console.WriteLine(j);
            j++;
            Console.WriteLine(j);
            j++;
            Console.WriteLine(j);
            j++;
            Console.WriteLine(j);

            Console.ReadLine();
        }
    }
}
