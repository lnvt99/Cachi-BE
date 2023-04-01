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
        private readonly Cachi_DBContext _cachiDBContext;
        private readonly Bill _bill;

        public BillsService(Cachi_DBContext cachiDBContext, Bill bill)
        {
            _cachiDBContext = cachiDBContext;
            _bill = bill;
        }

        public async Task<List<Bill>> getAllBills()
        {
            return await _cachiDBContext.Bills.ToListAsync();
        }
    }
}
