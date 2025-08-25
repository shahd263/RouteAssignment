using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answers> Choices { get; set; }

        public Answers RightAnswer { get; set; }




        

        public override string ToString()
        {
            return $"{Header}\n{Body}    {Mark} Marks";
        }
        public abstract void Display();

       
       public virtual void CreateQuestion(int qNumber)
        {
            Header = $"Question {qNumber}";

            Console.WriteLine(Header);

            Console.WriteLine("Enter Question Body");
            Body = Console.ReadLine() ?? "Invalid Question";
            Console.WriteLine("Enter The Question Mark");

            if (!int.TryParse(Console.ReadLine(), out int mark))
                mark = 2;
            Mark = mark;

        }

    }



        
    }

