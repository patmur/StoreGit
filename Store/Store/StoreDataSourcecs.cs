using System.Linq;

namespace Store
{
    public interface StoreDataSourcecs
    {
        IQueryable<Products> Products { get; } 
        IQueryable<User> User { get; }
    }
}
