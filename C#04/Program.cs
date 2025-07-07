using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Transactions;

namespace C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q6
            ////Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter an integer");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //    Console.WriteLine(i);

            #endregion


            #region Q7
            ////Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter an integer");
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(num*i);
            //}

            #endregion


            #region Q8
            //// Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter an integer");
            //int num = int.Parse(Console.ReadLine());

            //for(int i = 1; i<=num; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}  

            #endregion


            #region Q9
            ////Write a program that takes two integers then prints the power.

            //Console.WriteLine("Enter 2 integers");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int power = 1;

            //for (int i = 0; i < num2; i++)
            //    power *= num1; 

            //Console.WriteLine($"power= {power}");




            #endregion


            #region Q10
            //Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Enter Marks of five Subjects");
            //int[] arr = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());

            //}
            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    total += arr[i];

            //}
            //Console.WriteLine($"Total Marks: {total}");
            //Console.WriteLine($"Average Marks: {total / 5}");
            //int percentage = (int)(((double)total / 500) * 100);
            //Console.WriteLine($"Percntage: {percentage}");


            #endregion


            #region Q11
            ////Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter the month number");
            //int num = int.Parse(Console.ReadLine());

            //int days = num switch
            //{
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            //    4 or 6 or 9 or 11 => 30,
            //    2 => 28
            //};

            //Console.WriteLine($" Days in month: {days}");

            #endregion


            #region Q12
            ////Write a program to create a Simple Calculator.

            //Console.WriteLine("Enter 2 number to calulate");
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Operator Sign");
            //char op = char.Parse(Console.ReadLine());
            //double result;


            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid input");
            //        return;
            //}
            //Console.WriteLine($"Result = {result}");



            #endregion


            #region Q13
            ////Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("Enter a String");
            //String str = Console.ReadLine();
            //String reverse = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reverse = reverse + str[i];

            //}

            //Console.WriteLine($"Reverse: {reverse}");

            #endregion


            #region Q14
            ////Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("Enter an integer");
            //int num = int.Parse(Console.ReadLine());

            //int reverse=0 , remainder;


            //while (num != 0)
            //{
            //    remainder = num % 10;
            //    reverse=reverse *10 + remainder;
            //    num /= 10;

            //}

            //Console.WriteLine($"Reversed: {reverse}");


            #endregion

            #region Q15
            ////Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("Enter Starting number of range");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Ending number of range");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    int count = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0) count++;
            //        if (count > 2) break;
            //    }        

            //    if (count == 2)
            //        Console.Write($"{i} ");


            //}


            #endregion

            #region Q17
            ////Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Enter the First Point");
            //int x1=int.Parse(Console.ReadLine());
            //int y1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Point");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third Point");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //double m1 = (y2 - y1) / (x2 - x1);
            //double m2 = (y3 - y1) / (x3 - x1);
            //if(m1==m2) 
            //    Console.WriteLine("They Lie on a single straight line");
            //else
            //    Console.WriteLine("They Don't lie on a single straight line");

            #endregion


            #region Q18
            //Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task

            Console.WriteLine("Enter the time taken for the task");
            double time = double.Parse(Console.ReadLine());

            if (time >= 2 && time <= 3)
                Console.WriteLine("Highly Efficient");
            else if (time > 3 && time <= 4)
                Console.WriteLine("Increase Your Speed");
            else if (time > 4 && time <= 5)
                Console.WriteLine("Train to enhance your speed");
            else if (time > 5)
                Console.WriteLine("Leave The Company");


            #endregion




        }
    }
}
 