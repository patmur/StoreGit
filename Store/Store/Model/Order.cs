using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Order
    {
        public virtual string Date { get; set; }
        public virtual int Id { get; set; }
        public virtual ICollection <Products> type { get; set; }
    }
}
