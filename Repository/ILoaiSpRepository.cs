using DE15.Models;

namespace DE15.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSach Add(TLoaiSach loaiSach);
        TLoaiSach Update(TLoaiSach loaiSach);
        TLoaiSach Delete(string maLoaiSach);
        TLoaiSach GetLoaiSach(string maLoaiSach);
        IEnumerable<TLoaiSach> GetAllLoaiSach();

    }
}
