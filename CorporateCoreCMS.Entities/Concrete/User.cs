using System;
using System.Collections.Generic;
using System.Text;
using CorporateCoreCMS.Entities.Abstract;

namespace CorporateCoreCMS.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cover { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }

        public int? AuthorizationId { get; set; }
        public Authorization Authorization { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
