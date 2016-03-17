using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface StoreDataSourcecs
    {
        IQueryable<Products> Products { get; } 
        IQueryable<User> User { get; }
    }
}
