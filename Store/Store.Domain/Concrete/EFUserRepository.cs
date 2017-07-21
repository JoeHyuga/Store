using Store.Domain.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Entity;

namespace Store.Domain.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        EFDbContext context = new EFDbContext();
        public bool DeleteUser(string userid)
        {
            return true;
        }

        public User GetUser()
        {
            User user = new User { UserId=1,UserName="Joe",Sex="M",Email="ddddd@qq.com"};
            return user;
        }

        public bool SaveUserInfo(User user)
        {
            return true;
        }
    }
}
