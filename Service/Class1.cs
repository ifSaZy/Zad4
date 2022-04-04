using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;

namespace Service
{
    public class Class1
    {
        public static bool login(string login, string passsword)
        {
            ModelDBContainer DataBase = new ModelDBContainer();
            var user = DataBase.Users.FirstOrDefault(x => x.Login == login);

            if (user == null)
            {
                return false;
            }
            else
            {
                if (user.Password == passsword)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }
        }
    }
}
