using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelpBox.Core.Models
{
    public class User
    {
        public User()
        {
            Customers = new Collection<Customer>();
            Senders = new Collection<Sender>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool UserType { get; set; }
        public string UserDoc { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Communication { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string IdentityNumber { get; set; }
        public ICollection<Sender> Senders { get; set; }
        public ICollection<Customer> Customers{ get; set; }
    }
}
