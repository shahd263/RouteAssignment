namespace C_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            #endregion

            #region Q2
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            int num2 = int.Parse(Console.ReadLine());
            if (num2 < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");

            #endregion

            #region Q3
            //Write a program that takes 3 integers from the user then prints the max element and the min element.
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());
                arr[i] = x;
            }
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < 3; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"Max Number is {max} , Min Number is {min}");

            #endregion

            #region Q4 

            //Write a program that allows the user to insert an integer number then check If a number is even or odd.

            int num3 = int.Parse(Console.ReadLine());
            if (num3 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");



            #endregion


            #region Q5

            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).


            char c = char.Parse(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
            
            #endregion

        }
    }
}
