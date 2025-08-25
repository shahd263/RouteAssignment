using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        
        public FinalExam(TimeSpan time, int numberOfQestions ) : base(time, numberOfQestions)
        {
            Questions = new List<Question>();
        }

        public override void ShowExam(Answers[] UserAnswer)
        {  
           if (Questions is not null)
           {
            int score = 0,Grade=0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Question q = Questions[i];
                q.Display();
                Console.WriteLine($"Your Answer :: {UserAnswer[i]}");
                Console.WriteLine($"Correct Answer :: {q.RightAnswer}");
                Console.WriteLine("-----------------------------------------");
                score += q.Mark;
                if (q.RightAnswer == UserAnswer[i])
                    Grade += q.Mark;

             }
             Console.WriteLine($"Your Grade : {Grade}/{score} ");
            }
        }
    }
}
