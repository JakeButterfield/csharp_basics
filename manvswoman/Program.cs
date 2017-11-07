using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Human man = new Human("Dave", 30, "Male", 100, 1300);
            Human woman = new Human("Paula", 32, "Female", 100, 1300);

            Battle battle = new Battle(man, woman);

            Console.ReadKey();

        }
    }
}
