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
            #region sec 4 input output
            //int result = 0;
            ////sec 4 input output           
            //Console.Write("Please input here year : ");
            //string inputd = Console.ReadLine();
            //try
            //{
            //    int.TryParse(inputd, out result);
            //    result += 543;
            //}
            //catch
            //{

            //}
            //Console.WriteLine("Hello :" + inputd);
            //Console.WriteLine("Hello Year:"  + result);
            #endregion
            //sec 5 IF Structure
            #region sec 5 IF Structure
            //int score;
            //Console.Write("Input your score");
            //int.TryParse(Console.ReadLine(), out score);
            //if (score >= 80 && score <= 100)
            //{
            //    Console.Write("Your Pass !!!");
            //}
            //else if(score >= 60 || score < 80)
            //{
            //    Console.Write("Your Grade B+");
            //}
            //else
            //{
            //    Console.Write("Not Pass");
            //}

            #endregion
            #region sec 6 Switch case
            int score;
            string grade ="";
            Console.Write("Input your score");
            int.TryParse(Console.ReadLine(), out score);
           switch(score)
            {
                case 80:
                    grade = "A";
                    break;
                case 70:
                    grade = "B";
                    break;
                case 60:
                    grade = "C";
                    break;
                default:
                    grade = "F";
                    break;

            }
            Console.Write(grade);
            #endregion
            Console.ReadKey();


            //constants
            //const int size = 5;
            const float PI = 3.14f;
            //const double G = 9.8;
            // Constant
            float r = 4;

            float area = PI * r * r;
            float circumference = 2 * PI * r;
            float volume = (4 / 3.0f) * PI * r * r;
            float suface = 4 * PI * r * r;

            Console.WriteLine("Circle radius = {0}", r);
            Console.WriteLine("Circle area = {0}", area);
            Console.WriteLine("Circle circumference = {0}", circumference);
            Console.WriteLine("Circle volum = {0}", volume);
            Console.WriteLine("Circle surface = {0}", suface);
            Console.ReadKey();

            //
            //Program array
            const int SIZE = 5;

            string[] names = new string[SIZE];
            int[] scoress = new int[SIZE];

            Console.WriteLine("Enter name and score of {0} players", SIZE);
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("Player {0} name: ", i + 1);
                names[i] = Console.ReadLine();
                Console.Write("Player {0} score: ", i+1);
                scoress[i] = Int32.Parse(Console.ReadLine());
            }
            int maxIndex = 0;
            for(int i = 0; i < SIZE; i++)
            {
                if(scoress[i] > scoress[maxIndex])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine("{0} is the winner with score {1}", names[maxIndex], scoress[maxIndex]);
            Console.ReadLine();
        }
    }
}
