using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.EntityFrameworkCore;


namespace QUANLYLICHLAMVIEC.Data
{
    internal class QUANLYLICHLAMVIECConnection
    {
        public class QLLichDbContext : DbContext  // ✅ phải kế thừa DbContext
        {
            public DbSet<NhanVien> NhanVien { get; set; }
            public DbSet<CaLam> CaLam { get; set; }
            public DbSet<LichLamViec> LichLamViec { get; set; }

            // EF Core OnConfiguring
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\SQLEXPRESS;Database=QUANLYLICHLAMVIEC;Trusted_Connection=True;TrustServerCertificate=True;"
                );
            }
        }
    }
}
