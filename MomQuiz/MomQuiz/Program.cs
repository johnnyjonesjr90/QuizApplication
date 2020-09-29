using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MomQuiz
{
    public class Program
    {
        public delegate int Qes();
        static void Main(string[] args)
        {

            RandomQuestion rq = new RandomQuestion();
            Questions questions = new Questions();
            Console.WriteLine("In this practice exam you will be presented with a question followed by a series of answers.\n" +
                "to answer simply type in the letter that corrisponds to the answer and press enter. be sure not to enter a space\n" +
                "or any other characters... Press Enter");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("How many questions would you like in this quiz?\n(Press the number associated to the amount you want and press Enter...)\n\n" +
                "1 - 1 question\n" +
                "5 - 5 questions\n" +
                "10 - 10 questions\n" +
                "15 - 15 questions");
            int choice = Convert.ToInt32(Console.ReadLine());
            int totalscore = 0;
            Random rand = new Random();
            
            
            for(int i = 1; i<choice; i++)
            {
                Console.Clear();
                Console.WriteLine($"Question {i} out of {choice}\n\n");
                totalscore+= rq.Rando();            
            }
            Console.Clear();
            Console.WriteLine($"\n\n" +
                $"" +
                $"Your Score:{totalscore} | Total Possible Score: {choice*10}\n");
            Console.ReadKey();
            

        }
    }
}
