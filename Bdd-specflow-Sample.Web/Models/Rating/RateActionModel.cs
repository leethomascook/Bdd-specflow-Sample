using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bdd_specflow_Sample.Web.Models.Action;

namespace Bdd_specflow_Sample.Web.Models.Rating
{
    public class RateActionModel
    {
        public bool Successfull { get; set; }
        public SuggestedNextActionModel NextAction { get; set; }
    }
}