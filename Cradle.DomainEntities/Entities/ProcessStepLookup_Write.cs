using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class ProcessStepLookup_Write : EntityBase<ProcessStepLookup_Write>
    {
        public virtual Process Process { get; set; }
        public virtual ProcessStep ProcessStep { get; set; }
        public virtual string Description { get; set; }
        public virtual string Value { get; set; }
    }
}
