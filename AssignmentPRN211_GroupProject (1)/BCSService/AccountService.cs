using BCSRepository;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSService
{
    public class AccountService : IAccountService
    {
        private IAccountRepository repo;
        public AccountService()
        {
            repo = new AccountRepository();
        }

        public void AddAccount(Account account)
        {
            repo.AddAccount(account);
        }

        public void DeleteAccount(int userId)
        {
            repo.DeleteAccount(userId);
        }

        public List<Account> GetAllAccount() => repo.GetAllAccount();

        public void UpdateAccount(Account account)
        {
            repo.UpdateAccount(account);
        }

        Account IAccountService.GetAccountByEmail(string email)
        {
            return repo.GetAccountByEmail(email);
        }

        public Account? GetAnAccount(int userId)
        {
            return repo.GetAccountById(userId);
        }

        public Account? Get(int userId)
        {
            return repo.GetAccountById(userId);
        }

        public List<Account> SearchAccounts(string keyword)
        {
            return repo.SearchAccounts(keyword);
        }
    }
}
