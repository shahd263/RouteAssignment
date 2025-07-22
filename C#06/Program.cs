using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_06
{
    public class Person
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            ////-------------Answer--------------
            ////Value Type => get a copy from the variable and doesn't affect the original variable
            ////Reference Type => reference to the original variable(address) and affect it 

            ////passing by value 
            //static void increment1 (int x)
            //{
            //    x++;
            //}

            //int x = 5 ;
            //increment1 (x);
            //Console.WriteLine(x);   //remains 5

            //----------------------------------------------
            ////Passing by reference
            //static void increment2( ref int x)
            //{
            //    x++;
            //}

            //int y = 5; 
            //increment2(ref y);
            //Console.WriteLine(y);  //incremented and became 6 

            #endregion


            #region Q2
            ////2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            ////----------Answer-------------------
            ////Passing by value => point to the reference and can modify object data but cannot replace the object
            ////Passing by Reference => can replace the object 

            ////passing by value 
            //static void updateName1(Person person)
            //{
            //    person.Name = "Shahd";
            //    person = new Person();
            //    person.Name = "Shahd Mustafa"; // does not affect the original object


            //}

            //Person person = new Person();
            //person.Name = "Nada";
            //updateName1(person);
            //Console.WriteLine(person.Name); //Prints Shahd only 


            ////------------------------------------------
            ////Passing by Reference 
            //static void updateName2(ref Person person)
            //{
            //    person.Name = "Shahd";
            //    person = new Person();
            //    person.Name = "Shahd Mustafa"; //affects the original object 

            //}

            //Person person1 = new Person();
            //person1.Name = "Nada";
            //updateName2(ref person1); //Prints Shahd Mustafa 
            //Console.WriteLine(person1.Name);

            #endregion


            #region Q3
            ////Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //static void Calculator (int n1 , int n2 , out int sum , out int sub)
            //{
            //    sum = n1 + n2;
            //    if (n1>=n2)
            //        sub = n1 - n2;
            //   else 
            //        sub = n2- n1;

            //}

            //Calculator(5, 6, out int sum, out int sub);

            //Console.WriteLine($"Sum = {sum}  ,   subrtraction = {sub}");
            #endregion


            #region Q4
            ////Write a program in C# Sharp to create a function to calculate the sum of
            ////the individual digits of a given number.
            ////Output should be like
            ////Enter a number: 25
            ////The sum of the digits of the number 25 is: 7



            //static int NoOfDidits(int num)

            //{
            //    int sum = 0;
            //    while (num > 0)
            //    {
            //        int remainder = num % 10;
            //        sum += remainder;
            //        num /= 10;

            //    }
            //    return sum;
            //}

            //Console.WriteLine(NoOfDidits(25));

            #endregion


            #region Q5
            ////Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //static bool isPrime(int x)
            //{
            //    int count = 0;
            //    for (int i = 1; i <= x; i++)
            //    {
            //        count++;
            //        if (count > 2) return false;
            //    }
            //    return true;
            //}
            //Console.WriteLine(isPrime(4));

            #endregion


            #region Q6
            ////Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray (int[] arr , out int min , out int max)
            //{
            //    Array.Sort(arr);
            //    min = arr[0];
            //    max = arr[arr.Length];

            //}
            //int[] arr = { 5, 4, 7, 9, 6, 8 };
            //MinMaxArray(arr, out int min , out int max);
            //Console.WriteLine($"Max : {max} , Min : {min}");

            #endregion


            #region Q7
            ////Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //static int Factorial (int num)
            //{
            //    int ans = 1;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        ans *= i;

            //    }

            //    return ans;
            //}

            //Console.WriteLine(Factorial(5));



            #endregion


            #region Q8
            //Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter

            static string ChangeChar(string str , char c , int i )
            {
                if (i < str.Length)
                {
                    char[] chars = str.ToCharArray();
                    chars[i] = c;
                    return new string(chars);
                }
                else
                    return "out of range";
            }


            Console.WriteLine(ChangeChar("shahdm", 'd',5 ));
            #endregion



        }
    }
}
