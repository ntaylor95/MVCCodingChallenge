using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IHasId
    {
       long Id { get; set; }
    }

    public interface IHasFullName
    {
        string FullName { get;}
    }
}
