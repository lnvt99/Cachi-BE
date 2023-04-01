using Entity.Models.Bills;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class SettingDbContext: DbContext
    {
        public DbSet<BillsModel> BillsModels { get; set; }

        public SettingDbContext() : base() { }

        public SettingDbContext(DbContextOptions<SettingDbContext> options): base(options) { 
        
        }
    }
}
