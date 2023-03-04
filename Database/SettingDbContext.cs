using Entity.Model;
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
        public DbSet<ExampleModel> ExampleModels { get; set; }

        public SettingDbContext() : base() { }

        public SettingDbContext(DbContextOptions<SettingDbContext> options): base(options) { 
        
        }
    }
}
