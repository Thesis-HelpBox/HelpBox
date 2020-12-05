using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Core.Models
{
    public class ProductionRequest
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime ProductRequestDate { get; set; }


    }
}
