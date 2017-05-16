using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    public interface IEntityBase<T>
    {
        long ID { get; set; }
    }
}
