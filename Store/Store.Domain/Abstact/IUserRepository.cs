using Store.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Abstact
{
    public interface IUserRepository
    {
        User GetUser();
        bool DeleteUser(string userid);
        bool SaveUserInfo(User user);
    }
}
