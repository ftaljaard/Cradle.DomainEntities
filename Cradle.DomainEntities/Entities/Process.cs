using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class Process : EntityBase<Process>
    {
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual bool isActive { get; set; }
        public virtual UserGroup UserGroup { get; set; }
        public virtual List<ProcessStep> ProcessSteps { get; set; }
    }
}
