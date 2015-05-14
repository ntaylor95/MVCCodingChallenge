using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Person : BaseStorageModel<long>, IHasId, IHasFullName
    {
        #region constructor

        public Person() : base()
        { }

        public Person(long id) :
			base(id)
		{
		}

        #endregion constructor

        #region properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);            
            }
        }

        #endregion properties
    }
}
