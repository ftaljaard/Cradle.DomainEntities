using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class ProcessMembers : EntityBase<ProcessMembers>
    {
        public virtual Process Process { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
