using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class UserGroup: EntityBase<UserGroup>
    {
        public virtual string Name { get; set; }
    }
}
