using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class Users : EntityBase<Users>, IAuditable, IActivatable
    {
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }
        public virtual bool isActive { get; set; }
        public virtual string Site { get; set; }
        public virtual UserGroup UserGroup { get; set; }
        //permissions Maintenance
        public virtual bool AllowMasterItem { get; set; }
        public virtual bool AllowLocation { get; set; }
        public virtual bool AllowCategory { get; set; }
        public virtual bool AllowType { get; set; }
        public virtual bool AllowUser { get; set; }
        //permissions InventoryControl
        public virtual bool AllowTrackingEntity { get; set; }
        public virtual bool AllowScrapTrackingEntity { get; set; }
        public virtual bool AllowAdjustTrackingEntity { get; set; }
        public virtual bool AllowReclassify { get; set; }
        public virtual bool AllowConsume { get; set; }
        public virtual bool AllowConsumePost { get; set; }
        public virtual bool AllowManufacture { get; set; }
        public virtual bool AllowManufacturePost { get; set; }
        //permissions Operational
        public virtual bool AllowLabeling { get; set; }
        public virtual bool AllowReceiving { get; set; }
        public virtual bool AllowReceivingPosting { get; set; }
        public virtual bool AllowReceivingCompletion { get; set; }
        public virtual bool AllowReceivingDocument { get; set; }
        public virtual bool AllowReturns { get; set; }
        public virtual bool AllowReturnsPosting { get; set; }
        public virtual bool AllowDynamicPick { get; set; }
        public virtual bool AllowPicking { get; set; }
        public virtual bool AllowPickingPosting { get; set; }
        public virtual bool AllowPickingCompletion { get; set; }
        public virtual bool AllowPickingDocument { get; set; }
        public virtual bool AllowReplenish { get; set; }
        public virtual bool AllowQualityControl { get; set; }
        //permissions transfers
        public virtual bool AllowMoves { get; set; }
        public virtual bool AllowTransfer { get; set; }
        public virtual bool AllowTransferDocument { get; set; }
        public virtual bool AllowTransferPosting { get; set; }
        public virtual bool AllowTransferDynamic { get; set; }
        public virtual bool AllowTransferDynamicPosting { get; set; }
        //permissions Stock Take
        public virtual bool AllowStockTakeProcess { get; set; }
        public virtual bool AllowStockTakeStatusControl { get; set; }
        public virtual bool AllowStockTakePosting { get; set; }
        //Permission Data Capture
        public virtual bool AllowDataCapture { get; set; }
        public virtual bool AllowIntegration { get; set; }
        public virtual bool AllowPacking { get; set; }
        public virtual bool AllowPalletize { get; set; }
        //audit
        public virtual string AuditUser { get; set; }
        public virtual DateTime? AuditDate { get; set; }
    }
}
