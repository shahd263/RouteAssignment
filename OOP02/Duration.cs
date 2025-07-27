using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    //1. Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }



        public Duration() { }
      
        public Duration (int hours, int minutes, int seconds)
        {
            Hours = hours ;
            Minutes = minutes ;
            Seconds = seconds ;

            
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;

            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;

            }

        }

        public Duration(int seconds) 
        {
            Hours = seconds / 3600;
            int remainder = seconds % 3600;
            Minutes = remainder/60;
            Seconds = remainder % 60;
        }

        
        //2. Override All System.Object Members (ToString, Equals,GetHasCode) .

        public override string ToString()
        {
            return $"Hours: {Hours} , Minutes: {Minutes}, Seconds: {Seconds} ";
        }



        //D3=D1+D2
        public static Duration operator +(Duration D1, Duration D2)
        {
            int h = D1.Hours+D2.Hours;
            int m = D1.Minutes+D2.Minutes;
            int s = D1.Seconds+D2.Seconds;
              
            return new Duration(h,m,s);



        }
        //D3=D1 + 7800
        public static Duration operator +(Duration D1 , int seconds)
        {
            
            return new Duration(D1.Hours, D1.Minutes,D1.Seconds+seconds);

        }

        //D3=666+D3
        public static Duration operator +(int seconds, Duration D1)
        {

            return new Duration(D1.Hours, D1.Minutes, D1.Seconds + seconds);
        }

        //D3= ++D1 (Increase One Minute)
        public static Duration operator ++(Duration D1)
        {
            return new Duration (D1.Hours, D1.Minutes+1, D1.Seconds);
        }


        //D3 = --D2 (Decrease One Minute)

        public static Duration operator --(Duration D1)
        {

            return new Duration(D1.Hours, D1.Minutes - 1, D1.Seconds);
        }



        //D1= D1-D2
        public static Duration operator -(Duration D1,Duration D2)
        {
            int h = Math.Abs(D1.Hours - D2.Hours);
            int m = Math.Abs(D1.Minutes - D2.Minutes);
            int s = Math.Abs(D1.Seconds - D2.Seconds);
            return new Duration(h,m,s);
        }

        //If (D1>D2)

        public int sum()
        {
            return Hours*3600 + Minutes*60 +Seconds;
        }
        public static bool operator > (Duration D1, Duration D2)
        {
            return D1.sum() > D2.sum();

        }
        public static bool operator <(Duration D1, Duration D2)
        {
            return D1.sum() < D2.sum();

        }
        //If (D1<=D2)

        
        public static bool operator <=(Duration D1, Duration D2)
        {
            return D1.sum() <= D2.sum();

        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            return D1.sum() >= D2.sum();

        }


        //If (D1)
        public static bool operator true (Duration D1)
        {
           return D1.Hours !=0 || D1.Minutes != 0 || D1.Seconds !=0;

        }

        public static bool operator false(Duration D1)
        {
            return D1.Hours == 0 && D1.Minutes == 0 && D1.Seconds == 0;

        }


        //DateTime obj = (DateTime)D1

        public static explicit operator DateTime(Duration D1)
        {
            return new DateTime(2025,7,26,D1.Hours,D1.Minutes,D1.Seconds);
        }







    }

}
