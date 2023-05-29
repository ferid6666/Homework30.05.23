using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._30._05._23
{


    public class Engineer : Employee
    {
        private decimal salary;
        public new decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 1000)
                    salary = 1000;
                else
                    salary = value;
            }
        }
    }

}
