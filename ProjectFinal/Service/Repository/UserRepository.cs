using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Service.Repository
{
    public class UserRepository
    {

        public bool checkUser(string username, string password)
        {
            try
            {
                var result = DataProvider.Ins.DB.USERS.Where(p => p.user_name == username && p.password == password).Count();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
