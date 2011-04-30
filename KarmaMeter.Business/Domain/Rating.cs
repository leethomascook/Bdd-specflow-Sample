using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarmaMeter.Business.Domain
{
    public class Rating
    {
        public virtual Guid UserId { get; set; }
        public virtual Guid Id { get; set; }
        public virtual int SubmittedRating { get; set; }
        public virtual DateTime TimeRated { get; set; }
        public virtual User User { get; set; }
    }
}
