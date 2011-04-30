using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarmaMetee.Business.Domain
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual string Username { get; set; }
    }
}
