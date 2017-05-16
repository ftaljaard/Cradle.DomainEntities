using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class ApplicationExceptions : EntityBase<ApplicationExceptions>
    {
        public virtual string Description { get; set; }
        public virtual string MethodName { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
