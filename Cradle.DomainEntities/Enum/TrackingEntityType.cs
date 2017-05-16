using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities.Enum
{
    [Serializable]
    public enum TrackingEntityType
    {
        Pallet,
        TrackingEntity
    }
    [Serializable]
    public enum TransferType
    {
        Transfer,
        Intransit,
        Receipt
    }
}
