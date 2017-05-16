using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class CarryingEntity : EntityBase<CarryingEntity>, ITrackable<CarryingEntity>
    {
        public virtual string Barcode { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual Type type { get; set; }
        public virtual Status Status { get; set; }
        public virtual Location Location { get; set; }
        public virtual List<TrackingEntity> TrackingEntities { get; set; }
    }
}
