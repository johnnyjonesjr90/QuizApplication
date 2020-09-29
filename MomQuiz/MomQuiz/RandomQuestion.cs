using System;
using System.Collections.Generic;
using System.Text;

namespace MomQuiz
{
    public class RandomQuestion
    {
        Questions questions = new Questions();
        Random rand = new Random();
        public int[] skip = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public int Rando()
        {
            int totalscore = 0;
            int quiz = rand.Next(1, 17);
            switch (quiz)
            {
                case 1:
                    totalscore += questions.Q1();
                    break;
                case 2:
                    totalscore += questions.Q2();
                    break;
                case 3:
                    totalscore += questions.Q3();
                    break;
                case 4:
                    totalscore += questions.Q4();
                    break;
                case 5:
                    totalscore += questions.Q5();
                    break;
                case 6:
                    totalscore += questions.Q6();
                    break;
                case 7:
                    totalscore += questions.Q7();
                    break;
                case 8:
                    totalscore += questions.Q8();
                    break;
                case 9:
                    totalscore += questions.Q9();
                    break;
                case 10:
                    totalscore += questions.Q10();
                    break;
                case 11:
                    totalscore += questions.Q11();
                    break;
                case 12:
                    totalscore += questions.Q12();
                    break;
                case 13:
                    totalscore += questions.Q13();
                    break;
                case 14:
                    totalscore += questions.Q14();
                    break;
                case 15:
                    totalscore += questions.Q15();
                    break;
                case 16:
                    totalscore += questions.Q16();
                    break;
                case 17:
                    totalscore += questions.Q17();
                    break;
            }
            return totalscore;
        }
    }
}
