using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYLICHLAMVIEC.Data
{
    internal class LichLamViec
    {
        public int ID { get; set; }

        public int NhanVienID { get; set; }
        public int CaLamID { get; set; }

        public DateTime NgayLam { get; set; }
        public string? GhiChu { get; set; }
        public string TrangThai { get; set; } // "Đi làm", "Nghỉ", "Đổi ca"

        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual CaLam CaLam { get; set; } = null!;
        
    }
}
