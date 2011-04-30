using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using KarmaMetee.Business.Domain;

namespace KarmaMeter.DataAccess.Maps
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(u => u.Id).GeneratedBy.GuidComb();
            Map(u => u.Username).Unique();
        }
    }
}
