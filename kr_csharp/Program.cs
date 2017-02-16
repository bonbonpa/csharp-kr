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
            int result = 0;
            //sec 4 input output
            Console.Write("Please input here year : ");
            string inputd = Console.ReadLine();
            try
            {
                int.TryParse(inputd, out result);
                result += 543;
            }
            catch
            {

            }

            Console.WriteLine("Hello :" + inputd);
            Console.WriteLine("Hello Year:"  + result);
            Console.ReadKey();
        }
    }
}
