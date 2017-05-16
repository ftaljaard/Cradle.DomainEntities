using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    //Mapped to View Accpac_ItemUOM
    [Serializable]
    public class MasterItemAlias : EntityBase<MasterItemAlias>
    {
        public virtual Cradle.DomainEntities.MasterItem MasterItem { get; set; }
        public virtual string Code { get; set; }
        public virtual string UOM { get; set; }
        public virtual decimal Conversion { get; set; }
        public virtual bool IsActive { get; set; }
    }
}