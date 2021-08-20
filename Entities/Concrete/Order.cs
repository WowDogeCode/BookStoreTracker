using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int AccountId { get; set; }
    }
}
