using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarmaMeter.Business.Domain
{
    public class Action
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int DefaultRating { get; set; }
    }
}
