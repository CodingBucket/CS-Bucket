using Demo.SOLID.LiskovSubstitution.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.SOLID.LiskovSubstitution.Implementation
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee() { }

        public PermanentEmployee(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .5M;
        }

        public override decimal GetMinimumSalary()
        {
            return 50000;
        }
    }
}
