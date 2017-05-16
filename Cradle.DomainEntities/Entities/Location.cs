using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class Location : EntityBase<Location>, IAuditable, IActivatable
    {
        public Location() 
        {
            Site = "";
            ERPLocation = "";
            isActive = true;
            NonStock = false;
        }

        public virtual string Barcode { get; set; }
        public virtual string Name { get; set; }
        public virtual string Site { get; set; }
        public virtual Status Status { get; set; }
        public virtual Type Type { get; set; }
        public virtual Category Category { get; set; }
        public virtual bool isActive { get; set; }
        public virtual string ERPLocation { get; set; }
        public virtual bool NonStock { get; set; }
        public virtual string AuditUser { get; set; }
        public virtual DateTime? AuditDate { get; set; }
    }
}
