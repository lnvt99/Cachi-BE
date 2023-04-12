using Entity.Entity.Material;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IMaterialService
    {
        Task<List<Material>> getAllMaterial();
        Task<Material> getMaterialById(int id);
        Task<bool> createMaterial(Material material);
        Task<bool> updateMaterial(Material material, int id);
        Task<bool> deleteMaterial(int id);

    }
}
