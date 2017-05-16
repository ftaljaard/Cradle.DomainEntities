using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class EntityBase<T> : IEntityBase<T>
        where T : class
    {
        public virtual long ID { get; set; }
    }
}
