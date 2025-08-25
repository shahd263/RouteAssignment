using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Answers 
    {
        public int AnswerID { get; set; } = 0;
        public string AnswerText { get; set; } = "No Answer";

        public Answers(int answerID, string answerText)
        {
            AnswerID = answerID;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"{AnswerID}. {AnswerText}";
            
        }

        public static bool operator ==(Answers a, Answers b) {
            return a?.AnswerID == b?.AnswerID;
        }

        public static  bool operator != (Answers a, Answers b)
        {
            return a?.AnswerID != b?.AnswerID;
        }
    }
}
