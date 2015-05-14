using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dependent : Person
    {
        #region constructor

        public Dependent() : base()
        { }

        public Dependent(long dependentId) :
			base(dependentId)
		{
		}

        #endregion constructor

        #region properties

        public long EmployeeId { get; set; }

        #endregion properties

        #region methods

        #endregion methods
    }
}
