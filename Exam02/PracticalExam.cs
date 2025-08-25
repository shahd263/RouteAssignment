using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
       
        public PracticalExam(TimeSpan time, int numberOfQestions) : base(time, numberOfQestions)
        {
            Questions = new List<Question>();

        }

        public override void ShowExam(Answers[] UserAnswers)
        {
            if (Questions is not null && UserAnswers is not null)
            {
                for (int i = 0; i < NumberOfQuestions; i++)
            {
                    Question q = Questions[i];

                    Console.WriteLine($"Correct Answer :: {q.RightAnswer.ToString()} ");
                    Console.WriteLine($"Your Answer :: {UserAnswers[0]}");

                }
            }
        }
    }
}
