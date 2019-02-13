using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInputGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Typing_Challenge.First_Mode();        
        }
    }
    class Typing_Challenge
    {        
        public static void First_Mode ()
        {
            List<char> input = new List<char>();
            var time = DateTime.UtcNow;
            int count = 0;
            int userTime = 0;
            Console.WriteLine("Input the time you want game to run for in seconds");
            userTime = Convert.ToInt32(Console.ReadLine());

            do
            {
                input.Add(Console.ReadKey().KeyChar);                
            } while (DateTime.UtcNow - time < TimeSpan.FromSeconds(userTime));

            Console.WriteLine(" ");
            Console.WriteLine("Time is up!");
            Console.WriteLine(" ");
            Console.Write(" You inputted the following  { ");
            for (int j = 0; j < input.Count; j++)
            {
                Console.Write(input[j]);
                count = j;
            }
            Console.Write(" } ");
            Console.WriteLine(" You entered a total of: "+count+" characters.");
        }
    }
}
