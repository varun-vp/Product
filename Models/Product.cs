using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitOurProductExample.Models
{
    public class Product
    {
        [Key]
        public int PId{ get; set; }
        public string PName { get; set; }
        public int PDesc { get; set; }
        public int PPrice { get; set; }


    }
}
