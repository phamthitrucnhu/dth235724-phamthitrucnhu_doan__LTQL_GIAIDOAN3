using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYLICHLAMVIEC.Data
{
    internal class CaLam
    {
        public int ID { get; set; }
        public string TenCa { get; set; }      // Ca sáng, chiều, tối
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }

        public virtual ObservableCollectionListSource<LichLamViec> LichLamViec { get; } = new();
    }
}
