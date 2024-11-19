using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratanceTargil8020
{
    public class Employee
    {
        // שדות
        protected string name;
        protected int salary;
        protected DateTime startDate;
        protected const int defaultSalary = 10000;
        protected static int numEmployees = 0;
        // בנאי עם כל הפרמטרים
        public Employee(string name, DateTime startDate, int salary)
        {
            this.name = name;
            this.startDate = startDate;
            this.salary = salary;
            numEmployees++; // הגדלת כמות העובדים
        }

        // בנאי עם פרמטר של שם בלבד
        public Employee(string name) : this(name, DateTime.Now, defaultSalary)
        {
        }
        // בנאי ריק שקורא לבנאי הראשי
        public Employee() : this("EinShem", DateTime.Now, defaultSalary)
        {
        }
        // פעולה לחישוב הבונוס בהתבסס על שנות עבודה
        public int Vacation(int multiplier)
        {
            // Default vacation days calculation logic
            return (DateTime.Now.Year - startDate.Year) * multiplier;
        }

        public virtual int Bonus()
        {
            return (DateAndTime.Now.Year - startDate.Year) * 10;
        }
        public override string ToString()
        {
            return $"Employee: {name}, Salary: {salary}, Start Date: {startDate.ToShortDateString()}";
        }



    }
}
