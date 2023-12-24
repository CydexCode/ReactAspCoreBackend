using Microsoft.EntityFrameworkCore;
using ReactAspCRUD.Models;

namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CYDEX; Initial Catalog=lbs; User Id=sa; password=sachi123; TrustServerCertificate= True");
        }
    }
}