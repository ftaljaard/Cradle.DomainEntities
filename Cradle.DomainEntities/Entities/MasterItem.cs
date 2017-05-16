using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class MasterItem : EntityBase<MasterItem>, IActivatable, IAuditable
    {
        public virtual string Code { get; set; }
        public virtual string FormattedCode { get; set; }
        public virtual string Description { get; set; }
        public virtual string UOM { get; set; }
        public virtual bool isActive { get; set; }
        public virtual Category Category { get; set; }
        public virtual Type Type { get; set; }
        //Reorder
        public virtual decimal MaximumReorderQty { get; set; }
        public virtual decimal MinimumReorderQty { get; set; }
        //Pickface
        public virtual Location PickfaceLocation { get; set; }
        public virtual decimal MinimumPickfaceQuantity { get; set; }
        public virtual decimal OptimalPickfaceQuantity { get; set; }
        public virtual bool SinglePickface { get; set; }
        //Putwaway
        public virtual Location PutawayLocation { get; set; }
        public virtual bool SinglePutaway { get; set; }
        //Expiry - LeadTime
        public virtual int ShelfLife { get; set; }
        public virtual int LeadTime { get; set; }
        //OnHold
        public virtual bool DirectOnHold { get; set; }
        // Unit
        public virtual decimal UnitValue { get; set; }
        public virtual decimal UnitWeight { get; set; }
        public virtual int PickingSequence { get; set; }
        // Enforce Scanner Data Entry
        public virtual bool EnforceSerialNumber { get; set; }
        public virtual bool EnforceBatchNumber { get; set; }
        public virtual bool EnforceExpiryDate { get; set; }
        // Enforce Location Management and Validation
        public virtual bool EnforceTypeMatchInLocations { get; set; }
        public virtual bool EnforceCategoryMatchInLocations { get; set; }
        //over receiving
        public virtual decimal OverReceivingAllowance { get; set; }
        public virtual string LabelName { get; set; }
        //audit
        public virtual string AuditUser { get; set; }
        public virtual DateTime? AuditDate { get; set; }
        //cycle count
        public virtual int Velocity { get; set; }
        public virtual DateTime? LastStockTakeDate { get; set; }
    }
}
