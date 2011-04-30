using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KarmaMeter.Business.Domain;

namespace KarmaMeter.Business.Contracts
{
    public interface IUserRepository
    {
        User GetUser(string username);
    }
}
