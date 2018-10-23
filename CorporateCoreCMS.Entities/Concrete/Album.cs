using System;
using System.Collections.Generic;
using System.Text;
using CorporateCoreCMS.Entities.Abstract;

namespace CorporateCoreCMS.Entities.Concrete
{
    public class Album : BaseEntity
    {
        public string Way { get; set; }
        public int? Order { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
