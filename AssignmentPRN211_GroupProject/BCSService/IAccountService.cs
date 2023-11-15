using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSService
{
    public interface iAccountService
    {
        public Account getUserByUsername(string username, string pass);

        public Account getUserById(string id);

        public Boolean updateUser(Account user);

        public Boolean deleteUser(Account user);

        public List<Account> getAllUsers();
      
        public Boolean createUser(Account user);
    }
        
}
