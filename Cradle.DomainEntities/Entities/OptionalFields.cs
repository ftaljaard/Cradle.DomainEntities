using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cradle.DomainEntities
{
    [Serializable]
    public class OptionalFields : EntityBase<OptionalFields>, IActivatable
    {
        //Constructor
        public OptionalFields() : base() { }
        //Property
        public virtual string Name { get; set; }
        public virtual bool isActive { get; set; }
        public virtual Cradle.DomainEntities.Enum.AppliesTo AppliesTo { get; set; }

    }

    [Serializable]
    public class OptionalFieldValues<T> : EntityBase<OptionalFieldValues<T>>
        where T : EntityBase<T>, new()
    {
        public virtual OptionalFields OptionalField { get; set; }
        public virtual string Value { get; set; }
        public virtual T BelongsTo { get; set; }
        public virtual string Name
        {
            get
            {
                if (OptionalField != null)
                    return OptionalField.Name;
                else
                    return "";
            }
        }

    }
}
