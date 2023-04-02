using Database;
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
    public class BillsService : IBillsService
    {
        private readonly SettingDbContext _settingDBContext;

        public BillsService(SettingDbContext settingDBContext)
        {
            _settingDBContext = settingDBContext;
        }

        public async Task<List<Bill>> getAllBills()
        {
            return await _settingDBContext.Bills.ToListAsync();
        }

        public async Task<Bill> getBillById(int id)
        {
            Bill billById = await _settingDBContext.Bills.FirstOrDefaultAsync(x => x.BillId == id);
            return billById;
        }
    }
}
