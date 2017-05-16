using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities.Enum
{
    public enum BarcodeType : long
    {
        TRACKINGENTITY = 1,
        DOCUMENTINBOUND = 2,
        DOCUMENTOUTBOUND = 3,
        MASTERITEM = 4,
        PALLET = 5,
        BATCH = 6,
        BOX = 7
    }
}
