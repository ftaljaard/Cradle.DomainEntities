using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class MasterItemAlias_Write : EntityBase<MasterItemAlias_Write>, IAuditable
    {
        public virtual Cradle.DomainEntities.MasterItem MasterItem { get; set; }
        public virtual string Code { get; set; }
        public virtual string UOM { get; set; }
        public virtual decimal Conversion { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string AuditUser { get; set; }
        public virtual DateTime? AuditDate { get; set; }
    }
}
