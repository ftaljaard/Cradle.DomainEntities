using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class Document : EntityBase<Document>, IAuditable
    {
        public virtual string Number { get; set; }
        public virtual IList<DocumentDetail> Detail { get; set; }
        public virtual Type Type { get; set; }
        public virtual string TradingPartnerCode { get; set; }
        public virtual string TradingPartnerDescription { get; set; }
        public virtual Status Status { get; set; }
        public virtual bool isActive { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual DateTime? ActionDate { get; set; }
        public virtual string Description { get; set; }
        public virtual int Priority { get; set; }
        public virtual string ERPLocation { get; set; }
        public virtual string Site { get; set; }
        public virtual string AuditUser { get; set; }
        public virtual DateTime? AuditDate { get; set; }
    }
}
