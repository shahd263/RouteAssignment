using System.ComponentModel.Design;

namespace ADV03
{
    internal class Program
    {

        public static bool BalanceCheck(string str)
        {
            var s = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    s.Push(c);

                else if (c == ')' && s.Peek() == '(' || c == '}' && s.Peek() == '{' || c == ']' && s.Peek() == '[')
                    s.Pop();
                else
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {

            #region Q01
            //// implement a function to reverse the elements of a queue using a stack.Given a Queue,
            //var queue = new Queue<int>([1, 2, 3, 4, 5]);
            //var stack = new Stack<int>();

            //foreach (int i in queue)
            //    Console.Write($"{i} ");

            //Console.WriteLine();

            //while (queue.Count > 0) 
            //    stack.Push(queue.Dequeue());


            //while (stack.Count > 0) 
            //    queue.Enqueue(stack.Pop());

            //foreach (int i in queue)
            //    Console.Write($"{i} ");
            #endregion

            #region Q02
            //Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            Console.WriteLine("Enter parentheses");
            string str = Console.ReadLine();

            if(BalanceCheck(str))
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not Balanced");

            

            #endregion
        }
    }
}
