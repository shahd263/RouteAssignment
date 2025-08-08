using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ADV01
{


    internal class Program
    {
        #region Q1
        //The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
        //And implement the code of this optimized bubble sort algorithm

        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    bool check = false;
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) == 1)
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            check = true;
                        }


                    }
                    if (!check) return;
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //int[] arr = { 1, 3, 4, 7, 2, 8, 5, 6 };
            //BubbleSort<int>(arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion


            #region Q2
            Range<int> r = new Range<int>(10, 1);
            if(r.IsInRange(11))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine($"Length = {r.Length()}");


            #endregion



        }
    }
}
