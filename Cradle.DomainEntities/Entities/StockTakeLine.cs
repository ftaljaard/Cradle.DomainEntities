using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class StockTakeLine : EntityBase<StockTakeLine>
    {
        public virtual string Barcode { get; set; }
        public virtual Location Location { get; set; }
        public virtual decimal Qty { get; set; }
        public virtual Status Status { get; set; }
        public virtual StockTakeSession StockTakeSession { get; set; }
    }
}
