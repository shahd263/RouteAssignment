using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        public TimeSpan Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public List<Question>Questions { get; set; }



        public Exam(TimeSpan time , int numberOfQestions) { 
            Time = time;    
            NumberOfQuestions = numberOfQestions;
            Questions = new List<Question>();
        }
        public abstract void ShowExam(Answers[] UserAnswers);
        



    }
}
