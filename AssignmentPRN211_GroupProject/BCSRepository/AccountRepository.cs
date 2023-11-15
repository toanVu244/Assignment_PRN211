
using BCSDAO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSRepository
{
    public class AccountRepository : IAccountRepository
    {
        public void deleteUser(Account user)
        {
            throw new NotImplementedException();
        }

        public List<Account> getAllUsers()
        {
            return AccountDAO.Instance.getAll();
        }

        public Account getUserbyId(string id)
        {
            return AccountDAO.Instance.getByID(id);
        }

        public Account getUserbyUsername(string username)
        {
            return AccountDAO.Instance.getUserByUsername(username);
        }

        public void updateUser(Account user)
        {
            AccountDAO.Instance.updateUser(user);
        }

        public void createUser(Account user)
        {
            AccountDAO.Instance.createUser(user);
        }
    }
}
