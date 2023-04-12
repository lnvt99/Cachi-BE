using Entity.Models;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interface;
using Entity.Entity.Material;

namespace WebApiApplication.Controllers
{
    public class MaterialController : Controller
    {
        public IMaterialService? _materialService;

        /// <summary>
        /// Get all materials
        /// </summary>
        /// <returns>200</returns>
        [HttpGet("/getAllMaterial")]
        public ResponseBody<List<Material>> GetAllBills()
        {
            List<Material> data = _materialService.getAllMaterial().Result;
            try
            {
                return new ResponseBody<List<Material>>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<List<Material>>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }

        /// <summary>
        /// Get all material by id
        /// </summary>
        /// <returns>200</returns>
        [HttpGet("/getMaterial/{id}")]
        public ResponseBody<Material> GetMaterialById(int id)
        {
            Material data = _materialService.getMaterialById(id).Result;
            try
            {
                return new ResponseBody<Material>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<Material>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }

        /// <summary>
        /// Create material
        /// </summary>
        /// <returns>200</returns>
        [HttpPost("create/material")]
        public ResponseBody<bool> CreateMaterial(Material material)
        {
            bool data = _materialService?.createMaterial(material).Result == null ? false : true;
            try
            {
                return new ResponseBody<bool>
                {
                    Status = "",
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<bool>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }

        /// <summary>
        /// Update material
        /// </summary>
        /// <returns>200</returns>
        [HttpPut("update/material")]
        public ResponseBody<bool> UpdateMaterial(Material material, int id)
        {
            bool data = _materialService?.updateMaterial(material, id).Result == null ? false : true;
            try
            {
                return new ResponseBody<bool>
                {
                    Status = "",
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<bool>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }

        /// <summary>
        /// Delete material
        /// </summary>
        /// <returns>200</returns>
        [HttpDelete("Delete/material")]
        public ResponseBody<bool> DeleteMaterial(int id)
        {
            bool data = _materialService?.deleteMaterial(id).Result == null ? false : true;
            try
            {
                return new ResponseBody<bool>
                {
                    Status = "",
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<bool>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }
    }
}
