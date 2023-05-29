using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._30._05._23
{

    public class Employee
    {
        public string FullName { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 300)
                    salary = 300;
                else
                    salary = value;
            }
        }
    }
}
