using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Range<T> where T : IComparable<T>  , INumber<T>
    {
        public T  Max{ get; set; }
        public T Min { get; set; }

        public Range(T max ,T min) {
            Max = max;  
            Min = min;
        }

        public bool IsInRange(T value) {
            return Max.CompareTo(value) >= 0 && Min.CompareTo(value) <= 0;
                
        }

        public T Length()
        {
            return Max - Min;
        }



    }
}
