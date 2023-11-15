using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSRepository
{
    public interface IAccountRepository
    {
        public Account getUserbyUsername(string username);
        public  Account getUserbyId(string id);

        public void updateUser(Account user);  

        public void deleteUser(Account user);

        public List<Account> getAllUsers();
        public void createUser(Account user);
    }
}
