using System;
using System.Collections.Generic;

namespace PoliceComplains.Entities
{
    public partial class Complains
    {
        public Complains()
        {
            ComplainDocs = new HashSet<ComplainDocs>();
            ComplainFeedback = new HashSet<ComplainFeedback>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ComplainDocs> ComplainDocs { get; set; }
        public virtual ICollection<ComplainFeedback> ComplainFeedback { get; set; }
    }
}
