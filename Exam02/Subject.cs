using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Exam02
{
    internal class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Exam? Exam { get; set; }

        
        public Subject(int id, string name) {
            ID = id;    
            Name = name;
        }

        public void CreateExam()
        {
            Console.WriteLine("Enter Exam Type (1 => Final , 2 => Practical)");
            int eType = int.Parse(Console.ReadLine() ?? "2");

            Console.WriteLine("Enter Exam Duration in minutes");
            int time = int.Parse(Console.ReadLine() ?? "3" );

            Console.WriteLine("Enter Number Of Questions");
            int Qnum = int.Parse(Console.ReadLine() ?? "2");
            Console.Clear();



            if (eType == 1) Exam = new FinalExam(TimeSpan.FromMinutes(time), Qnum);
            else if (eType == 2) Exam = new PracticalExam(TimeSpan.FromMinutes(time), Qnum);
            else { Console.WriteLine("Invalid Input");
                return;
            }
            

                for (int i = 0; i < Qnum; i++)
                {
                    
                    int qType = 1;

                    if (Exam is FinalExam)
                    {
                        Console.WriteLine("Enter The Question Type(1 => mcq , 2 => True or False)" );
                        if (!int.TryParse(Console.ReadLine(), out  qType))
                            qType = 1;

                    Console.Clear();

                    }


                    Question q = new MCQ();

                    if (qType == 2)
                        q = new TrueOrFalse();
                    

                    q.CreateQuestion(i + 1);
                    Exam.Questions.Add(q);

                    Console.Clear();


                }
        }
    }
}
