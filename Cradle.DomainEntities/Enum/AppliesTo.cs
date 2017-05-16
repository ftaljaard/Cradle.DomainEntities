using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities.Enum
{
    public enum AppliesTo : int
    {
        DOCUMENT = 1,
        DOCUMENTDETAIL = 2,
        TRACKINGENTITY = 3,
        LOCATION = 4,
        MASTERITEM = 5,
        USERS = 6,
        TRANSACTION = 7,
        MACHINES = 8,
        LABEL = 9,
        BARCODE = 10,
        STOCKTAKE = 11,
        TRADINGPARTNER = 12,
        CONTAINABLEENTITY = 13
    }
}
