﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelationshipCoreFirst_ASPcore.Models;

namespace RelationshipCoreFirst_ASPcore.Migrations
{
    [DbContext(typeof(EFDataContext))]
    partial class EFDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RelationshipCoreFirst_ASPcore.Models.Post", b =>
                {
                    b.Property<int>("idPost")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("Title");

                    b.Property<int>("idUser");

                    b.HasKey("idPost");

                    b.HasIndex("idUser");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("RelationshipCoreFirst_ASPcore.Models.Role", b =>
                {
                    b.Property<int>("idRole")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("idRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RelationshipCoreFirst_ASPcore.Models.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("idUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RelationshipCoreFirst_ASPcore.Models.UserRole", b =>
                {
                    b.Property<int>("idUser");

                    b.Property<int>("idRole");

                    b.HasKey("idUser", "idRole");

                    b.HasIndex("idRole");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("RelationshipCoreFirst_ASPcore.Models.Post", b =>
                {
                    b.HasOne("RelationshipCoreFirst_ASPcore.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("RelationshipCoreFirst_ASPcore.Models.UserRole", b =>
                {
                    b.HasOne("RelationshipCoreFirst_ASPcore.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("idRole")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RelationshipCoreFirst_ASPcore.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}