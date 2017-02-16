using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello KR");
            Console.ReadLine();

            int number = 10;
            string num = "string";
            double db = 10.33;
            float fl = 100;
            bool gg = true;

            Console.WriteLine("MyName" + num);
            Console.WriteLine("Grade" + number);
            Console.WriteLine("Ages" + fl);
            Console.WriteLine("status" + gg);

            Console.ReadKey();
        }
    }
}
