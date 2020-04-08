using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace RelationshipCoreFirst_ASPcore.Models
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options)
               : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //config primary key(Role, User,Post,UserRole)
            modelBuilder.Entity<Post>().HasKey(s => s.idPost);
            modelBuilder.Entity<User>().HasKey(s => s.idUser);
            modelBuilder.Entity<Role>().HasKey(s => s.idRole);
            modelBuilder.Entity<UserRole>().HasKey(s =>
               new {
                   s.idUser,
                   s.idRole
               });

            //configuration relationship table(User & Post)
            modelBuilder.Entity<Post>()
                .HasOne(s => s.User)
                .WithMany(s => s.Posts)
                .HasForeignKey(s => s.idUser)
                .OnDelete(DeleteBehavior.Restrict);


            // Relationships table User,Role,UserRole
            modelBuilder.Entity<UserRole>()
              .HasOne<User>(sc => sc.User)
              .WithMany(s => s.UserRoles)
              .HasForeignKey(sc => sc.idUser);

            modelBuilder.Entity<UserRole>()
                .HasOne<Role>(sc => sc.Role)
                .WithMany(s => s.UserRoles)
                .HasForeignKey(sc => sc.idRole);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Post> Posts { get; set; }
       

    }
}
