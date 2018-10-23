﻿using System;
using System.Collections.Generic;
using System.Text;
using CorporateCoreCMS.Entities.Abstract;

namespace CorporateCoreCMS.Entities.Concrete
{
    public class Section : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Html { get; set; }
        public int Status { get; set; }
        public string Cover { get; set; }

    }
}
