using System;
using System.Collections.Generic;

namespace PoliceComplains.Entities
{
    public partial class ComplainFeedback
    {
        public int Id { get; set; }
        public int ComplainId { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }

        public virtual Complains Complain { get; set; }
        public virtual User User { get; set; }
    }
}
