using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class Transaction : EntityBase<Transaction>
    {
        public virtual TrackingEntity TrackingEntity { get; set; }
        public virtual CarryingEntity ContainableEntity { get; set; }
        public virtual TrackingEntity FromTrackingEntity { get; set; }
        public virtual Location FromLocation { get; set; }
        public virtual Location ToLocation { get; set; }
        public virtual MasterItem FromMasterItem { get; set; }
        public virtual MasterItem ToMasterItem { get; set; }
        public virtual string DocumentReference { get; set; }
        public virtual Document Document { get; set; }
        public virtual DocumentDetail DocumentLine { get; set; }
        public virtual DateTime? Date { get; set; }
        public virtual Users User { get; set; }
        //public virtual Status FromStatus { get; set; }
        //public virtual Status ToStatus { get; set; }
        public virtual decimal FromQty { get; set; }
        public virtual decimal ToQty { get; set; }
        public virtual decimal ActionQty { get; set; }
        public virtual string UOM { get; set; }
        public virtual decimal UOMConversion { get; set; }
        public virtual Type Type { get; set; }
        public virtual bool IntegrationStatus { get; set; }
        public virtual bool IntegrationReady { get; set; }
        public virtual string IntegrationReference { get; set; }
        public virtual DateTime? IntegrationDate { get; set; }
        public virtual string Comment { get; set; }
        public virtual Process Process { get; set; }
        public virtual string FromValue { get; set; }
        public virtual string ToValue { get; set; }
        public virtual OptionalFields OptionalField { get; set; }
    }
}
