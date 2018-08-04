using System;
using System.Collections.Generic;
using System.Text;

// Open Closed Principal: 
// Software entities such as classes, modules, functions, etc.should be open for extension, but closed for modification.

// Any new functionality should be implemented by adding new classes, attributes and methods, instead of chnaging the current ones or existing ones.

namespace Demo.SOLID.OpenClosed
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee() { }

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        { 
            return string.Format("ID : {0} Name : {1}", ID, Name);
        }
    }

    public class PermanentEmployee: Employee
    {
        public PermanentEmployee() { }

        public PermanentEmployee(int id, string name): base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .5M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }

        public TemporaryEmployee(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .2M;
        }
    }
}
