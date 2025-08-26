using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.Xml.Linq;

namespace ADV02
{
    
    internal class Program
    {
        //Q06
        public static int[] removeDuplicate(int[]arr) {
            HashSet<int> set = new HashSet<int>();
            foreach(int i in arr)
               set.Add(i);
            
            return set.ToArray();
        }

        //Q07
        public static void RemoveOdds(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] %2==1)
                    list.RemoveAt(i);
            }
        }
        static void Main(string[] args)
        {
            
            #region Q01
            ////you are given an arraylist containing a sequence of elements.
            ////try to reverse the order of elements in the arraylist in-place(in the same arraylist) without using the built-in reverse.
            ////implement a function that takes the arraylist as input and modifies it to have the reversed order of elements.

            //ArrayList arrayList = new ArrayList() { 1,2,3,4,5,6};


            //foreach (var item in arrayList)
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine();

            //int l = 0;
            //int r = arrayList.Count-1;
            //while (l < r) { 
            //    var temp =arrayList[l]; 
            //    arrayList[l] = arrayList[r];
            //    arrayList[r] = temp;
            //    l++;
            //    r--;

            //}

            //foreach (var item in arrayList)
            //{
            //    Console.Write($"{item} ");
            //}


            #endregion

            #region Q02
            ////You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //List<int> EvenList = new List<int>();

            //foreach (int i in list) { 
            //    if(i%2==0) EvenList.Add(i);
            //}

            //foreach (var item in EvenList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q03
            ////implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity

            //FixedSizeList<int> list = new FixedSizeList<int>(5);

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            ////list.Add(6); //Exception

            //Console.WriteLine(list.Get(3));







            #endregion

            #region Q04
            //Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.


            //Console.WriteLine("Enter the Size of Array");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Number of queries");
            //int qnum = int.Parse(Console.ReadLine());

            //var list = new List<int>();
            //for (int i = 0; i < n; i++) {
            //    Console.WriteLine($"Enter Array Element of index {i}");
            //    int item= int.Parse(Console.ReadLine());
            //    list.Add(item);
            //}

            //list.Sort();

            //for (int i = 0; i < qnum; i++) {
            //    Console.WriteLine($"Enter Qeury {i+1}");
            //    int q= int.Parse(Console.ReadLine());

            //    int count = 0;

            //    for(int j = 0; j < n; j++) {

            //        if (list[j] > q)
            //        {
            //            count = n - j;
            //            break;
            //        }



            //    }
            //    Console.WriteLine(count);
            //}

            #endregion

            #region Q05
            ////Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.WriteLine("Enter the Size of Array");
            //int n = int.Parse(Console.ReadLine());
            //var arr = new int[n];   
            //var stack = new Stack<int>();

            //for (int i = 0; i < n; i++) {
            //    Console.WriteLine($"Enter the Element of index {i}");
            //    int item = int.Parse(Console.ReadLine());
            //    arr[i] = item;
            //    stack.Push(item);

            //}
            //bool ans = true;
            //foreach (int i in arr) { 
            //    if (i!= stack.Pop())
            //    {
            //       ans = false;
            //        break;
            //    }

            //}
            //Console.WriteLine(ans);

            #endregion

            #region Q06
            //Given an array, implement a function to remove duplicate elements from an array.
            //int [] arr = new int[] { 1,5,2,3,2,5};

            //foreach(int i in arr)
            //    Console.Write($"{i} ");
            //Console.WriteLine();

            //arr =removeDuplicate(arr);

            //foreach (int i in arr)
            //    Console.Write($"{i} ");




            #endregion

            #region Q07
            // Given an array list , implement a function to remove all odd numbers from it.
            
            var arr = new List<int>() { 1,2,3,4,5,6,7,8,9,10};


            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();

            RemoveOdds(arr);

            foreach (int i in arr)
                Console.Write($"{i} ");


            #endregion

        }
    }
}
