using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class StockTakeSession : EntityBase<StockTakeSession>
    {
        public virtual string Name { get; set; }
        public virtual bool Active { get; set; }
        public virtual DateTime CreateDate { get; set; }
        private List<StockTakeLine> _lines;
        public virtual List<StockTakeLine> Lines
        {
            get { return this._lines; }
            set
            {
                this._lines = value;
            }
        }
    }
}
