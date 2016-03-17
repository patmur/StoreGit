using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
   public class User
    {
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string Type { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
    }
}
