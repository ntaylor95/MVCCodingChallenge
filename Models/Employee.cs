using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee : Person
    {
        #region constructor

        public Employee() : base()
        { }

        public Employee(long employeeId) :
			base(employeeId)
		{
		}

        #endregion constructor

        #region properties   
    
        public double Salary
        {
            get
            {
                return 2000.00;
            }
        }

        #endregion properties

        #region methods

        #endregion methods
    }
}
