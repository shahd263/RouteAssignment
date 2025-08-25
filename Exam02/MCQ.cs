using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ : Question
    {

        
        public override void Display()
        {
            Console.WriteLine(ToString());

            if (Choices is not null)
            {
                foreach (var item in Choices)
                    Console.WriteLine(item.ToString());               
            }
        }






        public override void CreateQuestion( int qNumber)
        {
            Console.WriteLine("--------MCQ Question----------");

            base.CreateQuestion(qNumber);

            Console.WriteLine("Enter the Number of Choices");

            if (!int.TryParse(Console.ReadLine(), out int n))
                n = 3;

            Choices = new List<Answers>();

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"Enter Choice Number {j + 1}");
                string choice = Console.ReadLine() ?? "-";
                Choices.Add(new Answers(j + 1, choice));
            }


            Console.WriteLine("Please Enter Correct Answer ID");

            if (!int.TryParse(Console.ReadLine(), out int id))
                id = -1;

            RightAnswer = Choices.Find(a => a.AnswerID == id) ?? new Answers(-1, "No Answer");

        }


    }
    }
