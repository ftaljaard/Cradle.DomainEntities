using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class Category : CategoryBase, ICategorizable, IEntityBase<Category>
    {
    }
}
