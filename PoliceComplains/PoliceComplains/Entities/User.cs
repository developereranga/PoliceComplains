using System;
using System.Collections.Generic;

namespace PoliceComplains.Entities
{
    public partial class User
    {
        public User()
        {
            ComplainFeedback = new HashSet<ComplainFeedback>();
            Complains = new HashSet<Complains>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NicNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Ip { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }

        public virtual ICollection<ComplainFeedback> ComplainFeedback { get; set; }
        public virtual ICollection<Complains> Complains { get; set; }
    }
}
