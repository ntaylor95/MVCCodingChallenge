using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BaseStorageModel<T>
    {
        #region constructor

        public BaseStorageModel()
        {
            CreateDate = DateTime.Now.ToUniversalTime();
            LastChanged = CreateDate;
        }

        public BaseStorageModel(T id)
            : this()
        {
            Id = id;
        }

        #endregion constructor

        #region properties

        public virtual T Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastChanged { get; set; }

        public string ChangedBy { get; set; }

        #endregion properties

        #region methods

        #endregion methods 
    }
}
