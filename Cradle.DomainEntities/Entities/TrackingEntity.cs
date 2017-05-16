using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class TrackingEntity : EntityBase<TrackingEntity>, ITrackable<TrackingEntity>
    {
        public virtual string Barcode { get; set; }
        public virtual decimal Qty { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual MasterItem MasterItem { get; set; }
        public virtual Location Location { get; set; }
        //public virtual Status Status { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ExpiryDate { get; set; }
        public virtual DateTime? ManufactureDate { get; set; }
        public virtual decimal Value { get; set; }
        public virtual string Batch { get; set; }
        public virtual Cradle.DomainEntities.CarryingEntity BelongsToEntity { get; set; }
        public virtual bool InStock { get; set; }
        public virtual bool OnHold { get; set; }
        public virtual bool StockTake { get; set; }
    }
}
