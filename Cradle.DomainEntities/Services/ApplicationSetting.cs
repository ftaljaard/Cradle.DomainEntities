using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class ApplicationSetting : EntityBase<ApplicationSetting>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Value { get; set; }
        public virtual bool isActive { get; set; }
    }
}
