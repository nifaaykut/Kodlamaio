using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Entities
{
    public class Instructor:BaseEntitiy
    {
        public int instructorId { get; set; }
        public string instructorfirstName { get; set;}
        public string instructorlastName { get; set;}
    }
}
