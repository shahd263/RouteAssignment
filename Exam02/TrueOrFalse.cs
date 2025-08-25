using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueOrFalse : Question

    {
        
        public TrueOrFalse() { 
            Choices = new List<Answers>();
            Choices.Add(new Answers(1, "True"));
            Choices.Add(new Answers(2, "False"));
        }

        public override void Display()
        {
            Console.WriteLine(ToString());

            Console.WriteLine("1. True | 2. False");

        }







        public override void CreateQuestion(int qNumber)
        {
            Console.WriteLine("-----------True | False Question-------------");

            base.CreateQuestion(qNumber);

            Console.WriteLine("Enter Correct Answer ID (1 => True , 2 => False)");
            if (!int.TryParse(Console.ReadLine(), out int id))
                id = -1;

            if (id == 1 || id == 2)
                RightAnswer = new Answers(id, id == 1 ? "True" : "False");

            else 
                RightAnswer = new Answers(-1, "No Answer");

            



        }

    }

}
