using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratanceTargil8020
{
    public class Guard : Employee
    {
        private string shift; // e.g., "Morning", "Evening", "Night"

        // Constructor
        public Guard(string name, DateTime startDate, int salary, string shift) : base(name, startDate, salary)
        {
            this.shift = shift;
        }

        // Overloaded constructor with default shift
        public Guard(string name, string shift) : base(name)
        {
            this.shift = shift;
        }

        // Override Bonus method
        public override int Bonus()
        {
            return 500; // Fixed bonus amount for guards
        }

        public override string ToString()
        {
            return base.ToString() + $", Shift = {this.shift}";
        }
    }
}
