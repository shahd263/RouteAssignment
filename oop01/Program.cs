using oop01.Encapsulation;
using System.Runtime.CompilerServices;

namespace oop01
{
    //Part01 Q1
    enum Weekdays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }

    //Part01 Q3
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    //Part 01 Q4
    enum Permissions
    {
        Read=1,
        Write=2,
        Delete=4,
        Execute=8

    }

    //Part 01 Q5
    enum Colors
    {
        Red,
        Blue,
        Green
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            #region Part01

            #region Q1
            ////Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (Weekdays day in Enum.GetValues (typeof(DayOfWeek)))
            //    Console.WriteLine(day);

            #endregion


            #region Q2
            ////Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Shahd",22);
            //persons[1] = new Person("Yousri", 25);
            //persons[2] = new Person("Omar", 9);

            //Console.WriteLine(persons[0].ToString());
            //Console.WriteLine(persons[1].ToString());
            //Console.WriteLine(persons[2].ToString());

            #endregion


            #region Q3
            /*
            Create an enum called "Season" with the four seasons 
            (Spring, Summer, Autumn, Winter) as its members. Write a 
            C# program that takes a season name as input from the user
            and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
             */

            //Console.WriteLine("Enter a season");
            //Season season = (Season)Enum.Parse(typeof(Season), Console.ReadLine(), true);


            //if (season == Season.Spring)
            //    Console.WriteLine("From March to May");
            //else if (season == Season.Summer)
            //    Console.WriteLine("From June to August");
            //else if (season == Season.Autumn)
            //    Console.WriteLine("From September to November");
            //else if (season == Season.Winter)
            //    Console.WriteLine("From December to February");

            #endregion


            #region Q4
            ////- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ////Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable


            //Permissions user1 = (Permissions)5;

            //if ((user1 & Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("The user has Read Permossion");

            //else
            //    user1^= Permissions.Read; //adds Read Permission

            #endregion


            #region Q5
            ////Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Enter A Color");
            //string color = Console.ReadLine();
            //bool isBasicColor = Enum.TryParse(color, true, out Colors primary);

            //if (!isBasicColor)
            //{
            //    Console.WriteLine($"{color} is not a primary Color");
            //}
            //else
            //    Console.WriteLine($"{color} is a primary color");


            #endregion


            #region Q6
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter the First Point (x1,y1)");
            //int x1 = int.Parse(Console.ReadLine()); 
            //int y1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Point (x2,y2)");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Point p1 = new Point(x1,y1);
            //Point p2 = new Point(x2,y2);

            //Console.WriteLine(Point.distance(p1,p2));

            //#endregion

            #endregion


            #region Q7
            //Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Shahd", 22);
            //persons[1] = new Person("Yousri", 25);
            //persons[2] = new Person("Omar", 9);

            //Person oldest = persons[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (persons[i].Age > oldest.Age)
            //    {
            //        oldest = persons[i];

            //    }
            //}
            //Console.WriteLine(oldest.ToString());
            #endregion
            #endregion



            #region Part02

            #region Q6
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1,"Shahd",22,SecurityLevel.DBA, 5000 , new HiringDate(1,1,2025),Gender.Female);
            EmpArr[0] = new Employee(2, "Nada", 20, SecurityLevel.Guest, 4000, new HiringDate(2, 2, 2025), Gender.Female);
            EmpArr[0] = new Employee(1, "Mustafa", 40, SecurityLevel.SecurityOfficer, 9000, new HiringDate(3, 3, 2025), Gender.Male);

            Console.WriteLine(EmpArr[0].ToString());





            #endregion

            #endregion
        }
    }
}
