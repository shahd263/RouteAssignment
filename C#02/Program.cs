namespace C_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Write a program that allows the user to enter a number then print it.


            //Console.WriteLine("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your Number is: {num}");

            #endregion

            #region Q2

            //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //String str = "Shahd";
            //int num = int.Parse(str); 
            //Console.WriteLine(num);
            ////Runtime Error (String is not in a correct format)


            #endregion

            #region Q3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //double num1 = 10.5;
            //double num2 = 2.5;

            //Console.WriteLine($"Sum = {num1 + num2}"); //sum = 13
            //Console.WriteLine($"Subtract = {num1 - num2}");//subtract = 8 
            //Console.WriteLine($"Multiply = {num1 * num2}");//Multiply = 26.25
            //Console.WriteLine($"Division = {num1 / num2}"); //Division = 4.2

            ////The result is decimal too 

            #endregion


            #region Q4

            //Write C# program that Extract a substring from a given string.

            //String str = "Shahd Mustafa";
            //String subStr = str.Substring(0, 5);
            //Console.WriteLine("Your Substring: "+ subStr); //Prints Shahd only

            #endregion


            #region Q5
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int x = 5;
            //int y = x; // y=5 now 
            //x = 10;
            //Console.WriteLine($"x= {x} , y= {y}"); //x= 10 , y= 5 They Print different values



            #endregion


            #region Q6

            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;

            //arr1[0] = 20;

            //Console.WriteLine($"arr1[0] = {arr1[0]} , arr2[0] = {arr2[0]}");
            ////arr1[0] = 20 , arr2[0] = 20 They contains the same value




            #endregion


            #region Q7

            //Write C# program that take two string variables and print them as one variable 

            //String str1 = "Shahd";
            //String str2 ="Mustafa";
            //String str3 = string.Concat(str1, str2);
            //Console.WriteLine(str3);  //ShahdMustfa

            #endregion



            // MCQ

            #region Q8 

            //Which of the following statements is correct about the C#.NET code snippet given below?
            //int d; 
            //d = Convert.ToInt32(!(30 < 20));

            //Answer -> b) A value 1 will be assigned to d.
            #endregion

            #region Q9
            //Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //Answer -> d) 6 1
            #endregion

            #region Q10
            //What will be the output of the C# code given below?
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //Answer -> d) 7 7



            #endregion









        }
    }
}
