using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    public interface IAuditable
    {
        string AuditUser { get; set; }
        DateTime? AuditDate { get; set; }
    }
}
