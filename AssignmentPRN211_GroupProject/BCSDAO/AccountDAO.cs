using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSDAO
{
    public class AccountDAO
    {
        public static AccountDAO instance;

        public AccountDAO() {
        
        }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }

        

        public Account getUserByUsername(string username)
        {
            try {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.Accounts.SingleOrDefault(c => c.Username.Equals(username));
            }
            catch(Exception e) {
                throw new Exception(e.Message);
            }         
        }

      

        public Account getByID(string id) {
            try
            {
                var dbcontent = new BirdCageShopContext();
                return dbcontent.Accounts.FirstOrDefault(a => a.UserId.Equals(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void updateUser(Account user)
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                 dbcontent.Accounts.Update(user);
                dbcontent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Account> getAll()
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
               return dbcontent.Accounts.OrderBy(a => a.UserId).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void createUser(Account user)
        {
            try
            {
                var dbcontent = new BirdCageShopContext();
                dbcontent.Accounts.Add(user);
                dbcontent.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
