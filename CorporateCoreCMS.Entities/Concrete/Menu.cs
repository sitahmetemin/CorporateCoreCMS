﻿using System;
using System.Collections.Generic;
using System.Text;
using CorporateCoreCMS.Entities.Abstract;

namespace CorporateCoreCMS.Entities.Concrete
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Icon { get; set; }
        public string Cover { get; set; }
        public string Type { get; set; }
        public bool Lock { get; set; }
        public int Status { get; set; }
        public int? Order { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Album> Albums { get; set; }

        public int? ParentMenuId { get; set; }
        public Menu ParentMenu { get; set; }

    }
}
