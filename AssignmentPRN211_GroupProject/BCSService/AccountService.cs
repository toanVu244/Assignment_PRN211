using BCSRepository;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSService
{
    public class AccountService : iAccountService
    {
        private IAccountRepository repo = new AccountRepository();

        public bool deleteUser(Account user)
        {
            throw new NotImplementedException();
        }

        public List<Account> getAllUsers()
        {
            return repo.getAllUsers();
        }

        public Account getUserById(string id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return repo.getUserbyId(id);
            }
        }

        public Account? getUserByUsername(string username,String pass)
        {
            if(string.IsNullOrEmpty(username)) return null;
            else
            {
                Account user = repo.getUserbyUsername(username);
                if (user.Password.Equals(pass))
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool updateUser(Account user)
        {
           if(user == null)
            {
                return false;
            }
            else
            {

                try
                {
                    repo.updateUser(user);
                    return true;
                }catch (Exception ex)
                {
                    return false;
                }
            }
        }

      
        public Boolean createUser(Account user)
        {
            if(user == null)
            {
                return false;
            }
            else
            {
                repo.createUser(user);
                return true;
            }
        }
    }
}
