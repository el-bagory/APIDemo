using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Entities.DbSet
{
    public abstract class BaseEntity
    {
         public Guid Id { get; set; } = Guid.NewGuid();
         public byte Status { get; set; }
         public DateTime CreateDate { get; set; } = DateTime.UtcNow;
         public DateTime UpdateDate { get; set; }
    }
}