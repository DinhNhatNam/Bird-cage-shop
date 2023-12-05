using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
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
        private BirdCageShopContext _dbContext;
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

        

         public Account? GetAccountByEmail (string email)
        {
            _dbContext = new BirdCageShopContext();
            return _dbContext.Accounts.SingleOrDefault(x => x.Email == email);
        }

        public List<Account> GetAllAccount()
        {           
            _dbContext = new BirdCageShopContext();
            return _dbContext.Accounts.Include(x => x.Role).ToList();
        }

        public void AddAccount (Account account)
        {
            _dbContext = new BirdCageShopContext();
            _dbContext.Accounts.Add(account);
            _dbContext.SaveChanges();
        }
        public void UpdateAccount(Account account)
        {
            _dbContext = new BirdCageShopContext();
            _dbContext.Accounts.Update(account);
            _dbContext.SaveChanges();
        }
        public void DeleteAccount(int userId)
        {
            _dbContext = new BirdCageShopContext();
            var account = _dbContext.Accounts.FirstOrDefault(x => x.UserId == userId);
            if (account != null)
            {
                _dbContext.Accounts.Remove(account);
                _dbContext.SaveChanges();
            }
        }

        public Account? GetAccountById (int userId)
        {
            _dbContext = new BirdCageShopContext();
            return _dbContext.Accounts.Find(userId);
        }

        public List<Account> SearchAccounts(string keyword)
        {
            return GetAllAccount().Where(x => x.Username.ToLower().Contains(keyword.ToLower()) ||
                                              x.Email.ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}
