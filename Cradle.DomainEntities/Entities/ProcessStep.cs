using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class ProcessStep : EntityBase<Process>
    {
        public virtual Process Process { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int ProcessIndex { get; set; }
        public virtual int NextIndex { get; set; }
        public virtual bool isActive { get; set; }
        public virtual bool Required { get; set; }
        public virtual string DefaultValue { get; set; }
        public virtual string PreScript { get; set; }
        public virtual List<ProcessStepLookup> ProcessStepLookups { get;set;} 
    }
}
