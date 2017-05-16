using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class BarcodeMaster : EntityBase<BarcodeMaster>
    {
        private Cradle.DomainEntities.Enum.BarcodeType _type;
        public virtual int NextBarcode { get; set; }
        public virtual string Name { get; set; }
        public virtual string Prefix { get; set; }
        public virtual int Length { get; set; }
    }
}
