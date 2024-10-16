using DE15.Models;

namespace DE15.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly QlthuVienContext _context; 
        public LoaiSpRepository(QlthuVienContext context)
        {
            _context = context;
        }
        public TLoaiSach Add(TLoaiSach loaiSach)
        {
            _context.Add(loaiSach);
            _context.SaveChanges();
            return loaiSach;
        }

        public TLoaiSach Delete(string maLoaiSach)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSach> GetAllLoaiSach()
        {
            return _context.TLoaiSaches;
        }

        public TLoaiSach GetLoaiSach(string maLoaiSach)
        {
            return _context.TLoaiSaches.Find(maLoaiSach);
        }

        public TLoaiSach Update(TLoaiSach loaiSach)
        {
            _context.Update(loaiSach);
            _context.SaveChanges ();
            return loaiSach;
        }
    }
}
