using Microsoft.EntityFrameworkCore;

namespace L02P02_2020PM605_2020SS601.Models
{
    public class libreriaDbContext : DbContext
    {
        public libreriaDbContext(DbContextOptions options): base(options) { }



    }
}
