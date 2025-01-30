using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DDD;
public abstract class Entity<T> : IEntity<T>
{
    public T Id { get ; set ; }
    public DateTime? CreatedAt { get ; set ; }
    public string? CreatedBy { get ; set ; }
    public DateTime? LastModified { get ; set ; }
    public DateTime? LastModifiedBy { get ; set ; }
}
