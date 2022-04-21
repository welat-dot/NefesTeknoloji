using CoreLayer.Utilitis.Security.Hashing;
using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class NefesContext:DbContext
    {
        public NefesContext(DbContextOptions<NefesContext> options) : base(options)
        {

        }
        public NefesContext()
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(@"Filename = default");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Personel>().HasKey(x => x.Id);
            modelBuilder.Entity<Birim>().HasKey(x => x.Id);
            modelBuilder.Entity<Personel>().
                HasOne<Birim>(p=>p.Birim).
                WithMany(b=>b.Personeller).
                HasForeignKey(p=>p.BirimId);
            byte[] passwordHash;
            byte[] passwordSalt;


            HashingHelper.CreateHash("admin", out passwordHash, out passwordSalt);
            modelBuilder.Entity<User>().HasData(new User
            {
                Id=Guid.NewGuid().ToString(),
                EmailAdress="admin@admin",
                PasswordHash=passwordHash,
                PasswordSalt=passwordSalt
            });
               
        }

        public DbSet<User>  User { get; set; }
        public DbSet<Birim>  Birim { get; set; }
        public DbSet<Personel> Personel { get; set; }


    }
}
