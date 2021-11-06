using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    
   public class Stock
    {
        /*stock defines how many and different 
         variation of 1 product available*/

        public int Id { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }


}
