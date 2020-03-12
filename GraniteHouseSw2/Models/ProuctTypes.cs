using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouseSw2.Models
{
    public class ProuctTypes
    {
        public int Id { get; set; }
       
        [Required]
        public String Name { get; set; }
    }
}
