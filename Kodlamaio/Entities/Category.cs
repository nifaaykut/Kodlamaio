using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Entities
{
    public class Category : BaseEntitiy
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
    }
}
