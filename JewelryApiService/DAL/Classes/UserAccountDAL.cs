using JewelryApiService.DAL.Interfaces;
using JewelryApiService.EFModels.DB;
using JewelryApiService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryApiService.DAL.Classes
{
    public class UserAccountDAL : iUserAccountDAL
    {
        private readonly JewelryManagementContext _dbContext;

        public UserAccountDAL(JewelryManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> UserLogin(User userObject)
        {
          var userObject_db=await _dbContext.UserLogins.Where(x => x.UserName == userObject.UserName && x.UserPassword == userObject.UserPassword).Select(z=>z.UserPrivilage).FirstOrDefaultAsync();
            return userObject_db;
          // var db=from user in_dbContext where user.Password== userObject.Password and user.UserName == userObject.UserName;
            
        }
    }
}
