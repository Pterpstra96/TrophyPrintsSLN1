using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrophyPrints.Models;

namespace TrophyPrints.Services
{
    public class SecurityService
    {
        
        UsersDAO userDAO = new UsersDAO();

        public SecurityService()
        {
            
        }

        public bool isValid(UserModel user)
        {
            return userDAO.VerifyUsersNandDOB(user);


        
        }
    }
}
