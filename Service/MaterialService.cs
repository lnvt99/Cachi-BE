using Database;
using Entity.Entity.Category;
using Entity.Entity.Material;
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
    public class MaterialService: IMaterialService
    {
        private readonly SettingDbContext _settingDBContext;

        public MaterialService(SettingDbContext settingDBContext)
        {
            _settingDBContext = settingDBContext;
        }

        public async Task<bool> createMaterial(Material responseMaterial)
        {
            bool result = true;
            Material data = new Material();
            data.MaterialName = responseMaterial.MaterialName;
            data.Price = responseMaterial.Price;
            data.Amount = responseMaterial.Amount;
            data.Unit = responseMaterial.Unit;
            data.IsDeleted = responseMaterial.IsDeleted;
            data.DateCreated = responseMaterial.DateCreated;
            data.DateLastModified = responseMaterial.DateLastModified;
            data.MaterialsRecipes = null;

            _settingDBContext.Materials.Add(data);
            _settingDBContext?.SaveChangesAsync();
            return result;
        }

        public async Task<bool> deleteMaterial(int id)
        {
            Material data = await getMaterialById(id);
            bool result = false;
            if (data != null)
            {
                _settingDBContext.Materials.Remove(data);
                _settingDBContext.SaveChanges();
                result = true;
            }
            return result;
        }

        public async Task<List<ResponseGetAllMaterial>> getAllMaterial()
        {
            List<Material> lstCategory = await _settingDBContext.Materials.ToListAsync(); ;
            List<ResponseGetAllMaterial> data = new List<ResponseGetAllMaterial>();
            lstCategory.ForEach(x =>
            {
                ResponseGetAllMaterial item = new ResponseGetAllMaterial();
                item.id = x.MaterialId; 
                item.name = x.MaterialName;
                item.amount = x.Amount;
                data.Add(item);
            });
            return data;
        }

        public async Task<Material> getMaterialById(int id)
        {
            return await _settingDBContext?.Materials?.FirstOrDefaultAsync(x => x.MaterialId == id);
        }

        public async Task<bool> updateMaterial(Material material, int id)
        {
            try {
                Material data = await getMaterialById(id);
                if (data != null)
                {
                    data.MaterialName = material.MaterialName;
                    data.Price = material.Price;
                    data.Amount = material.Amount;
                    data.Unit = material.Unit;
                    data.IsDeleted = material.IsDeleted;
                    data.DateCreated = material.DateCreated;
                    data.DateLastModified = material.DateLastModified;
                    data.MaterialsRecipes = null;
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
