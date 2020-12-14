using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Core.Models
{
    public class Sender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Communication { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string IdentityNumber { get; set; }
        public virtual User User { get; set; }
    }
}
