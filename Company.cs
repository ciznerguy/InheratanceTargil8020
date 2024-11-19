using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratanceTargil8020
{
    public class Company
    {
        string name; //company name
        Employee[] employees;


        public Company(string name, CEO ceo, int maxEmployees)
        {
           this.name = name;
           employees = new Employee[maxEmployees];

        }

    }

}
