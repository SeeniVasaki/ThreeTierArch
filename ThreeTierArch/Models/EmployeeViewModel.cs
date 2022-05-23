using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZHO.BAL.Models;

namespace ThreeTierArch.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Employees = new Employees();
        }

        public Employees Employees { get; set; }
    }
}
