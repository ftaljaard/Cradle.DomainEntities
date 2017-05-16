using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    public interface ICategorizable
    {
        string Name { get; set; }
        string Description { get; set; }
        Cradle.DomainEntities.Enum.AppliesTo AppliesTo { get; set; }
        bool isActive { get; set; }
        bool Locked { get; set; }
    }
}
