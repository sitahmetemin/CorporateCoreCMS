﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateCoreCMS.Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }
    }
}
