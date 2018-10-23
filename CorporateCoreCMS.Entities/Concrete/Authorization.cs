using System;
using System.Collections.Generic;
using System.Text;
using CorporateCoreCMS.Entities.Abstract;

namespace CorporateCoreCMS.Entities.Concrete
{
    public class Authorization : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
