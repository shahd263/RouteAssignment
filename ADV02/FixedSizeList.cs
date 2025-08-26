using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ADV02
{
    internal class FixedSizeList <T>
    {
        public int Capacity { get; }
        public T[] FixedList { get; set; }

        private int Count { get; set; }


        public FixedSizeList (int capacity)
        {
            this.Capacity = capacity;
            FixedList = new T[capacity];
            Count = 0;
        }


        public void Add(T item) 
        {
            if (Count == Capacity)
                throw new InvalidOperationException("The List Is Full");
            else
            {
                FixedList[Count] = item;
                Count++;
            }

            
        }
        public T Get(int index) 
        {
            if (index < Capacity)
                return FixedList[index];

            else
                throw new IndexOutOfRangeException("Invalid Index");

        }
    }
}
