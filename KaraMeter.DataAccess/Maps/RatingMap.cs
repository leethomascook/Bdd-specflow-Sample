using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KarmaMeter.Business.Domain;
using FluentNHibernate.Mapping;

namespace KaraMeter.DataAccess.Maps
{
    public class RatingMap : ClassMap<Rating>
    {
        public RatingMap()
        {
            Id(I => I.Id).GeneratedBy.GuidComb();
            Map(I => I.UserId);
            Map(I => I.TimeRated);
            Map(I => I.SubmittedRating);
            References(I => I.User);
        }
    }
}
