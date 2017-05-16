using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class ScannerSettings : EntityBase<ScannerSettings>
    {
        public virtual string Process { get; set; }
        public virtual string PropertyName { get; set; }
        public virtual string PropertyDescription { get; set; }
        public virtual int ProcessIndex { get; set; }
        public virtual bool isActive { get; set; }
        public virtual bool Locked { get; set; }
        public virtual string DefaultValue { get; set; }
        public virtual int NextIndex { get; set; }
    }
}
