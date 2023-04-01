using Database;
using Entity.Models;
using Entity.Models.Bills;
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

        public async Task<List<BillsModel>> getAllBills()
        {
            return await _settingDBContext.BillsModels.ToListAsync();
        }

        public async Task<BillsModel> getBillById(int id)
        {
            BillsModel billById = await _settingDBContext.BillsModels.FirstOrDefaultAsync(x => x.BillId == id);
            return billById;
        }
    }
}
