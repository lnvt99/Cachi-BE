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
using Util;

namespace Service
{
    public class AccountService: IAccountService
    {
        private readonly SettingDbContext _settingDBContext;

        private  readonly StringUtil StringUtil = new StringUtil();
        public AccountService(SettingDbContext settingDBContext)
        {
            _settingDBContext = settingDBContext;
        }

        public async Task<Account> GetAccount(RequestAccount requestAccount)
        {
            if (StringUtil.checkNullOrEmpty(requestAccount.UserName) || StringUtil.checkNullOrEmpty(requestAccount.Password)) {
                return null;
            }
            Account account = await _settingDBContext.Accounts.FirstOrDefaultAsync(x => x.Username == requestAccount.UserName && x.Password == requestAccount.Password);
            return account;
        }

        public async Task<List<ResponseAccount>> GetAllAccount()
        {
            List<Account> account = await _settingDBContext.Accounts.ToListAsync();
            List<ResponseAccount> response = new List<ResponseAccount>();
            account.ForEach(data =>
            {
                ResponseAccount result = new ResponseAccount()
                {
                    UserName = data.Username,
                    Password = data.Password,
                    Status = true
                };
               response.Add(result);
            });
            return response;
        }
    }
}
