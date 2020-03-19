using System;
using System.Collections.Generic;

namespace PoliceComplains.Entities
{
    public partial class ComplainDocs
    {
        public int Id { get; set; }
        public int ComplainId { get; set; }
        public string FileName { get; set; }
        public string RealName { get; set; }

        public virtual Complains Complain { get; set; }
    }
}
