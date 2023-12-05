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
        Account GetAccountByEmail(string email);
        List<Account> GetAllAccount();
        void AddAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(int userId);
        Account? GetAccountById(int userId);
        List<Account> SearchAccounts(string keyword);
    }
}
