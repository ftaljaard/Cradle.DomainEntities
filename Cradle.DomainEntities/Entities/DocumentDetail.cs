using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class DocumentDetail : EntityBase<DocumentDetail>, IAuditable
    {
        public virtual string LineNumber { get; set; }
        public virtual MasterItem Item { get; set; }
        public virtual decimal UOMQty { get; set; }
        public virtual string UOM { get; set; }
        public virtual decimal Qty { get; set; }
        public virtual decimal UOMConversion { get; set; }
        public virtual bool Completed { get; set; }
        public virtual Document Document { get; set; }
        public virtual decimal UnitValue { get; set; }
        public virtual string Comment { get; set; }
        public virtual Status Status { get; set; }
        public virtual Type Type { get; set; }
        public virtual DocumentDetail LinkedDetail { get; set; }
        public virtual decimal ActionQty { get; set; }
        public virtual decimal PackedQty { get; set; }
        public virtual bool MultipleEntries { get; set; }
        public virtual string FromLocation { get; set; }
        public virtual string ToLocation { get; set; }
        public virtual string IntransitLocation { get; set; }
        public virtual string Batch { get; set; }
        public virtual DateTime? ExpiryDate { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual string AuditUser { get; set; }
        public virtual DateTime? AuditDate { get; set; }
    }
}
