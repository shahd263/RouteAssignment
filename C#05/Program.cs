using System.Runtime.Serialization.Formatters;

namespace C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q19
            //// Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("Enter the Size of the matrix");
            //int n = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[n,n];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //   for(int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        if(j== i)
            //        {
            //            matrix[i, j] = 1;
            //        }
            //        Console.Write(matrix[i, j] +" ");
            //    }
            //    Console.WriteLine();
            //}





            #endregion


            #region Q20
            ////Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = { 1, 2, 3 ,4, 5};
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum+= arr[i];
            //}
            //Console.WriteLine("The sum of the Array Elements= "+sum);
            #endregion


            #region Q21
            ////Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 1, 3, 4, 2 };
            //int[] arr2 = { 7, 6, 8, 5 };

            //int[] merged = arr1.Concat(arr2).ToArray(); 
            //Array.Sort(merged);

            //foreach (int n in merged) 
            //    Console.WriteLine(n);


            #endregion

            #region Q22
            ////Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arr = { 1, 2, 3, 1, 4, 2, 1, 5, 6, 3, 5 };
            //Array.Sort(arr);
            //int[] freq = new int[arr[arr.Length - 1]+1];

            //foreach (int i in arr)
            //    freq[i]++;

            //for (int i = 0; i < freq.Length; i++)
            //{

            //    if (freq[i] != 0)
            //        Console.WriteLine($"Count of number {i}: {freq[i]}");
            //}





            #endregion


            #region Q23
            // Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = { 5, 7, 10, 9, 11, 15 };
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++) { 
            //    max = Math.Max(max, arr[i]);
            //    min= Math.Min(min, arr[i]);

            //}
            //Console.WriteLine($"Max number is : {max} ");
            //Console.WriteLine($"Min number is : {min}");




            #endregion


            #region Q24
            ////Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 5, 7, 10, 9, 11, 15 };
            //Array.Sort(arr);
            //Console.WriteLine($"The Second Largest element is : {arr[arr.Length-2]}");

            #endregion


            #region Q25
            ////Consider an Array of Integer values with size N, having values as in this Example

            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //    arr[i] = int.Parse(Console.ReadLine());


            //int max = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int count = 0;
            //    for (int j = n - 1; j > i; j--)
            //    {

            //        if (arr[i] == arr[j])
            //        {
            //            count = j - i - 1;
            //            break;
            //        }

            //    }
            //    max = Math.Max(max, count);
            //}

            //Console.WriteLine($"the Longest Lenght is: {max}");
            #endregion


            #region Q26
            ////Given a list of space separated words, reverse the order of the words.
            //Console.WriteLine("Enter a Text");
            //String text = Console.ReadLine();
            //String[] Words = text.Split(' ');
            //Array.Reverse(Words);

            //foreach (String w in Words)
            //    Console.Write(w + " ");

            ////another Solution ------------------------
            //Console.WriteLine(string.Join (" ",text.Split(' ').Reverse()));

            #endregion


            #region Q27
            ////Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.WriteLine("Enter the Size of the array n*m");
            //int n =int.Parse(Console.ReadLine());
            //int m =int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[n,m];
            //int[,] arr2 = new int[n, m];


            //for (int i = 0; i < n; i++)
            //{
            //    for (int  j = 0; j < m; j++)
            //        arr1[i,j] = int.Parse(Console.ReadLine());

            //}
            //Array.Copy(arr1 , arr2, arr1.Length);

            //for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < m; j++)
            //            Console.Write(arr2[i,j] + " ");

            //        Console.WriteLine();

            //    }



            #endregion



            #region Q28
            //Write a Program to Print One Dimensional Array in Reverse Order
            int[] arr = {1,2,3,4,5};

            for (int i = arr.Length-1; i>=0; i--) 
                Console.WriteLine(arr[i]);

            #endregion



        }
    }
}
