using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01.Encapsulation
{
    //Part02 Q1
    internal class Employee
    {
        private int id;
        private string name;
        private int age;
        private SecurityLevel securityLevel;
        private int salary;
        private HiringDate hiringDate;
        private Gender gender;

        public Employee (int _Id, string _Name, int _Age, SecurityLevel _SecurityLevel, int _Salary, HiringDate _HringDate, Gender _Gender)
        {
            Id = _Id;
            Name = _Name;
            Age = _Age;
            SecurityLevel = _SecurityLevel;
            Salary = _Salary;
            HiringDate = _HringDate;
            Gender = _Gender;
               
        }


        public Employee (String _Name, SecurityLevel _SecurityLevel , int _Salary)
        {
            Name = _Name;   
            SecurityLevel = _SecurityLevel;
            Salary = _Salary;
        }
           

        public int Id { get => id ; set { salary = value; } }
        public string Name { get => name; set { name = value; } }
        public int Age { get => age; set { age = value; } }

        public int Salary { get => salary; set {salary=value; } }

        public Gender Gender
        {
            get => gender;
            set
            {
                if (Enum.IsDefined(typeof(Gender), value))
                    gender = value;
                else
                    Console.WriteLine("Invalid Gender value.");
            }
        }

        public HiringDate HiringDate { get =>hiringDate; set { hiringDate = value; } }

        public SecurityLevel SecurityLevel
        {
            get => securityLevel;
            set
            {
                if (Enum.IsDefined(typeof(SecurityLevel), value))
                    securityLevel = value;
                else
                    Console.WriteLine("Invalid SecurityLevel value.");
            }
        }





        //Part02  Q5
        public override string ToString()
        {
            return $"Employee Name : {name}  , Salary : {salary} ";
        }

       

    }
}
