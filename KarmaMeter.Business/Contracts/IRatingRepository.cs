﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarmaMeter.Business.Contracts
{
    public interface IRatingRepository
    {
        bool HasStoryBeenRatedByUserAlready(Guid userId);
    }
}
