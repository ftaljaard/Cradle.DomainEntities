using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class IntegrationSettings : EntityBase<IntegrationSettings>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Value { get; set; }
        public virtual string Email { get; set; }
        public virtual bool Post { get; set; }
        public virtual bool isActive { get; set; }
    }
}
