using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01
{
    //Part01 Q2
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name; 
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name} , Age : {Age}";
        }


    }
}
