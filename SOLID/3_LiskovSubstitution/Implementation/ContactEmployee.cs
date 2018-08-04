using Demo.SOLID.LiskovSubstitution.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.SOLID.LiskovSubstitution.Implementation
{
    public class ContactEmployee: IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ContactEmployee() { }

        public ContactEmployee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
