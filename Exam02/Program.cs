using System.Globalization;
using System.Net.Quic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Exam02
{
    internal class Program


    {

        
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Maths");

            subject.CreateExam();


            Console.WriteLine("Do You want To Start The Exam? (Y|N)");
            char input = char.Parse(Console.ReadLine());

            if (input == 'Y' || input == 'y') {

                DateTime startTime=DateTime.Now;
                Exam e = subject.Exam;
                
                if (e is not null)
                {
                    Answers[] UserAnswers = new Answers[e.NumberOfQuestions];

                    for (int i = 0; i < e.NumberOfQuestions; i++)
                    {

                        if (DateTime.Now - startTime >= e.Time)
                        {
                            Console.WriteLine("Time is up! Exam ended.");
                            break;
                        }



                        if (e is FinalExam) Console.WriteLine("---------------FINAL EXAM---------------");
                        else Console.WriteLine("--------------Practical Exam------------------");

                        Console.WriteLine($"Exam Duration {e.Time} Minutes           {i}/{e.NumberOfQuestions} Question");



                        Question q = e.Questions[i];
                        q.Display();
                        if (!int.TryParse(Console.ReadLine(), out int ans))
                            ans = -1;
                        
                        UserAnswers[i]= q.Choices.Find(a => a.AnswerID == ans) ?? new Answers(ans, "Invalid Answer");

                        Console.Clear();

                    }
                    e.ShowExam(UserAnswers);
                    DateTime endTime = DateTime.Now;
                    TimeSpan timeTaken = endTime - startTime;


                    Console.WriteLine($"Time taken: {timeTaken.ToString(@"hh\:mm\:ss")}");

                    Console.WriteLine("--------------Thank You------------------");
                    
                }
                

            }














        }
    }
}
