using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Coupon { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public virtual Category Category { get; set; }


    }
}
