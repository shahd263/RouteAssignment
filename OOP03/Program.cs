using OOP03.Question01;
using OOP03.Question02;
using OOP03.Question03;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace OOP03
{

    internal class Program

    {
        
        static void Main(string[] args)
      {
            #region Part01
            #region Q1
            //What is the primary purpose of an interface in 
            //Answer ==>  b) To define a blueprint for a class
            #endregion

            #region Q2
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //Answer ==>  a) private
            #endregion

            #region Q3
            //Can an interface contain fields in C#?
            //Answer ==>  b) No 
            #endregion

            #region Q4
            //In C#, can an interface inherit from another interface?
            //Answer ==>  b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q5
            //Which keyword is used to implement an interface in a class in C#?
            //Answer ==>  d) implements (The correct answer is ':')
            #endregion

            #region Q6
            //Can an interface contain static methods in C#?            //Answer ==>  c) extends (The correct answer is ':')
            //Answer ==>  a)Yes
            #endregion

            #region Q7
            //In C#, can an interface have explicit access modifiers for its members?
            //Answer ==>  b) No, all members are implicitly public
            #endregion

            #region Q8
            //What is the purpose of an explicit interface implementation in C#?
            //Answer ==> b) To provide a clear separation between interface and class members

            #endregion

            #region Q9
            //In C#, can an interface have a constructor?
            //Answer ==> b) No, interfaces cannot have constructors
            #endregion

            #region Q10
            //How can a C# class implement multiple interfaces?
            //Answer ==> c) By separating interface names with commas
            #endregion

            #endregion

            #region Part02

            #region Q1

            //Circle c = new Circle(5);
            //c.DisplayShapeInfo();
            //Rectangle r = new Rectangle(6, 3);
            //r.DisplayShapeInfo();

            #endregion


            #region Q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //if (authService.AuthenticateUser("Shahd", "123456"))
            //    Console.WriteLine("Authenticated Successfully");
            //else
            //    Console.WriteLine("Authentication Failed");

            //if (authService.AuthorizeUser("Shahd",Role.Admin))
            //    Console.WriteLine("Authorized Successfully");
            //else
            //    Console.WriteLine("Authorization Failed");


            #endregion


            #region Q3
            
            EmailNotificationService email = new EmailNotificationService();
            email.SendNotification("Shahd@gmail.com", "Hello Shahd");

            SmsNotificationService sms = new SmsNotificationService();
            sms.SendNotification("0125646465", "Call Me");

            PushNotificationService push = new PushNotificationService();
            push.SendNotification("Shahd", "Instagram Message");


            #endregion

            #endregion
        }
    }
}
