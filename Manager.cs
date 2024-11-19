using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratanceTargil8020
{
    public class Manager : Employee 
    {
        // שדה המייצג את תואר המנהל
        protected string title;

        // בנאי עם כל הפרמטרים
        public Manager(string name, DateTime startDate, int salary, string title)
        : base(name, startDate, salary)
        {
            this.title = title;
        }

        public Manager()
        {
            this.title = "Manager"; // Default title
        }

        public Manager(string name) : base(name)
        {
            this.title = "Big Boss";
        }
    

        public override int Bonus()
        {
            return base.Bonus() * 3;
        }


        public Manager(int salary)
        {
            this.title = "Boss";
            this.salary = salary;
            this.name = "EinShem"; // שם ברירת מחדל
            this.startDate = DateTime.Now; // תאריך ברירת מחדל להיום
        }


        // דריסת ToString להחזרת פרטי המנהל
        public override string ToString()
        {
            return base.ToString() + $", Title: {title}, Vacation Days (mult=2): {base.Vacation(2)} days";
        }
    }

}
