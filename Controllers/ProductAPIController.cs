using DE15.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using DE15.Models.ProductModels;
namespace DE15.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {

        QlthuVienContext db = new QlthuVienContext();   
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var sanPham = (from p in db.TSaches
                           select new Product
                           {
                               MaSach = p.MaSach,
                               TenSach= p.TenSach,
                               MaLoai = p.MaLoai,
                               GiaTriSach = p.GiaTriSach,
                               FileAnh = p.FileAnh 
                           }).ToList();
            return sanPham;
        }
        [HttpGet("{maloai}")]
        public IEnumerable<Product> GetAllProductsByCategory(string maloai)
        {
            var sanPham = (from p in db.TSaches
                           where p.MaLoai == maloai
                           select new Product
                           {
                               MaSach = p.MaSach,
                               TenSach = p.TenSach,
                               MaLoai = p.MaLoai,
                               GiaTriSach = p.GiaTriSach,
                               FileAnh = p.FileAnh
                           }).ToList();
            return sanPham;
        }

    }
}
