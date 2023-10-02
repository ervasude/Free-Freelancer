using System;
using Free_Freelancer.Common;

namespace Free_Freelancer.Entities
{
    internal class Review : EntityBase<Guid>
    {
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}

