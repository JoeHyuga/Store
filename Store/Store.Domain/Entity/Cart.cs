using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entity
{
    public class Cart
    {
        public int ProductID { get; set; }
        public string UserID { get; set; }
        public decimal Amount { get; set; }
    }
}
