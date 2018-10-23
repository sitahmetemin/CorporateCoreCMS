using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateCoreCMS.Entities.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}
