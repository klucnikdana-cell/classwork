using System;
using System.Collections.Generic;
using System.Text;

namespace _20._10._26_Classwork_
{
    internal class Journal
    {
        public string Name {  get; set; }
        public int Employess {  get; set; }

        public Journal(string name,int employess)
        {
            Name = name;
            Employess = employess;
        }

        public static Journal operator +(Journal j,int number)
        {
            j.Employess += number;
            return j;
        }
        public static Journal operator -(Journal j, int number)
        {
            j.Employess -= number;
            return j;
        }
        public static bool operator ==(Journal j1,Journal j2 )
        {
            return j1.Employess == j2.Employess;
        }
        public static bool operator !=(Journal j1, Journal j2)
        {
            return j1.Employess == j2.Employess;
        }
        public static bool operator <(Journal j1, Journal j2)
        {
            return j1.Employess < j2.Employess;
        }
        public static bool operator >(Journal j1, Journal j2)
        {
            return j1.Employess > j2.Employess;
        }
        public override string ToString()
        {
            return $"Journal: {Name}, Employees: {Employess}";
        }
    } 

    internal class Shop
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shop(string name, double area)
        {
            Name = name;
            Area = area;
        }
        public static Shop operator +(string name, double area)
        {

        }
    }
}
