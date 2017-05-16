using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class StockTakeScanned : EntityBase<StockTakeScanned>
    {
        public virtual string Barcode { get; set; }
        public virtual Location Location { get; set; }
        public virtual decimal Count1Qty { get; set; }
        public virtual decimal Count2Qty { get; set; }
        public virtual decimal Count3Qty { get; set; }
        public virtual decimal FinalCountQty { get; set; }
        public virtual Status Status { get; set; }
        public virtual Users Count1User { get; set; }
        public virtual Users Count2User { get; set; }
        public virtual Users Count3User { get; set; }
        public virtual int Scans { get; set; }
        public virtual StockTakeSession StockTakeSession { get; set; }
        public virtual DateTime LastScanDate { get; set; }
        public virtual decimal Qty
        {
            get
            {
                return this.FinalCountQty;
            }
        }
    }
}
