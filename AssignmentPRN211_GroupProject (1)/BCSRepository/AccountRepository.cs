
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
        public void AddAccount(Account account) =>
            AccountDAO.Instance.AddAccount(account);

        public void DeleteAccount(int userId) =>
            AccountDAO.Instance.DeleteAccount(userId);

        public Account? GetAccountById(int userId) =>
            AccountDAO.Instance.GetAccountById(userId);

        public List<Account> GetAllAccount() =>
            AccountDAO.Instance.GetAllAccount();

        public List<Account> SearchAccounts(string keyword) =>
            AccountDAO.Instance.SearchAccounts(keyword);

        public void UpdateAccount(Account account) =>
            AccountDAO.Instance.UpdateAccount(account);

        Account IAccountRepository.GetAccountByEmail(string email) =>
            AccountDAO.Instance.GetAccountByEmail(email);
    }
}
