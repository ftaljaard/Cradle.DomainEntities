using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class CategoryBase : EntityBase<CategoryBase>, IActivatable, ICategorizable, IAuditable
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool isActive { get; set; }
        public virtual Cradle.DomainEntities.Enum.AppliesTo AppliesTo { get; set; }
        public virtual bool Locked { get; set; }
        public virtual string AuditUser { get; set; }
        public virtual DateTime? AuditDate { get; set; }
    }
}
