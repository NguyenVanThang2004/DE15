using DE15.Repository;
using Microsoft.AspNetCore.Mvc;
namespace DE15.ViewComponents
{
    public class LoaiSachMenuViewComponent :ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;
        public LoaiSachMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSach().OrderBy(x => x.MaLoai);
            return View(loaisp);
        }
    }
}
