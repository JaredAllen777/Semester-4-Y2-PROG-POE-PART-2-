using Microsoft.EntityFrameworkCore;
using PROGPOE2ST10271869.Models;
 

//_________________________________START OF FILE______________________________________\\

namespace PROGPOE2ST10271869.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        DbSet<Lecturer> Lecturers { get; set; }
    }
}

//_________________________________________END OF FILE_________________________________\\