using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarmaMetee.Business.Contracts
{
    public interface IRatingRepository
    {
        bool HasStoryBeenRatedByUserAlready(string username);
    }
}
