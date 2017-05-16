using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    //Mapped to View Accpac_ItemUOM
    [Serializable]
    public class ItemSegment : EntityBase<ItemSegment>
    {
        public virtual string Segment { get; set; }
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }
    }
}
