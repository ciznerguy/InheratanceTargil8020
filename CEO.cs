using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratanceTargil8020
{
    public class CEO : Manager
    {
        private int stockOptions; // New field specific to CEO

        // Constructor with full initialization
         
        
        public CEO(string name, DateTime startDate, int salary, string title, int stockOptions)
            : base(name, startDate, salary, title)
        {
            this.stockOptions = stockOptions;
        }

        // Constructor with default values
        public CEO() : base("Unknown CEO", DateTime.Now, 50000, "CEO")
        {
            this.stockOptions = 10000; // Default stock options
        }

        // Override the Bonus method
        public override int Bonus()
        {
            // Base Bonus (from Manager) + stock options * 10
            return base.Bonus() + (this.stockOptions * 10);
        }

        public override string ToString()
        {
            // Add stock options to the ToString method
            return base.ToString() + $", Stock Options = {this.stockOptions}";
        }
    }
}
