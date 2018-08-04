using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.SOLID.LiskovSubstitution.Interface
{
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
