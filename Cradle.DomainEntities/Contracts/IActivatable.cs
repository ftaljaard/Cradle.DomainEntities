using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{

    public interface IActivatable
    {
        //void Delete();
        bool isActive { get; set; }
    }
}
