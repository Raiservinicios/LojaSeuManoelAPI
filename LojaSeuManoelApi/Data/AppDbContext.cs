using Microsoft.EntityFrameworkCore;
using SeuManoelPackingApi.Models;
using System.Collections.Generic;

namespace LojaSeuManoelApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Caixa> Caixas { get; set; }
    }
}
