using Database;
using Entity.Entity.Account;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AccountService: IAccountService
    {
        private readonly SettingDbContext _settingDBContext;
        public AccountService(SettingDbContext settingDBContext)
        {
            _settingDBContext = settingDBContext;
        }

        public async Task<Account> GetAccount(RequestAccount requestAccount)
        {
            if (requestAccount.UserName == null || requestAccount.Password == null) {
                return null;
            }
            Account account = await _settingDBContext.Accounts.FirstOrDefaultAsync(x => x.Username == requestAccount.UserName && x.Password == requestAccount.Password);
            return account;
        }
    }
}
