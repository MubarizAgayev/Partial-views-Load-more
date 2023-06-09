﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task.Data;

#nullable disable

namespace Task.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230409211216_CreateContactTables")]
    partial class CreateContactTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Task.Models.AboutMemberInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutMemberInfos");
                });

            modelBuilder.Entity("Task.Models.AboutMembers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AboutMemberInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AboutMemberInfoId");

                    b.ToTable("AboutMembers");
                });

            modelBuilder.Entity("Task.Models.AboutSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AboutSliders");
                });

            modelBuilder.Entity("Task.Models.AboutSliderInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutSliderInfos");
                });

            modelBuilder.Entity("Task.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Task.Models.ContactHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactHeaders");
                });

            modelBuilder.Entity("Task.Models.ContactHeaderImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ContactHeaderImgs");
                });

            modelBuilder.Entity("Task.Models.RecentWorkImgs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecentWorksId")
                        .HasColumnType("int");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RecentWorksId");

                    b.ToTable("RecentWorkImgs");
                });

            modelBuilder.Entity("Task.Models.RecentWorks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RecentWorks");
                });

            modelBuilder.Entity("Task.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Titte")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Task.Models.SlideInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SlideInfos");
                });

            modelBuilder.Entity("Task.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Task.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("Task.Models.WorkImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<int>("WorksId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorksId");

                    b.ToTable("WorkImgs");
                });

            modelBuilder.Entity("Task.Models.Works", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WorkId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Task.Models.AboutMembers", b =>
                {
                    b.HasOne("Task.Models.AboutMemberInfo", "AboutMemberInfo")
                        .WithMany()
                        .HasForeignKey("AboutMemberInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AboutMemberInfo");
                });

            modelBuilder.Entity("Task.Models.RecentWorkImgs", b =>
                {
                    b.HasOne("Task.Models.RecentWorks", "RecentWorks")
                        .WithMany()
                        .HasForeignKey("RecentWorksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecentWorks");
                });

            modelBuilder.Entity("Task.Models.WorkImg", b =>
                {
                    b.HasOne("Task.Models.Works", "Works")
                        .WithMany()
                        .HasForeignKey("WorksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Works");
                });

            modelBuilder.Entity("Task.Models.Works", b =>
                {
                    b.HasOne("Task.Models.Category", "Category")
                        .WithMany("Works")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Task.Models.Work", "Work")
                        .WithMany()
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Work");
                });

            modelBuilder.Entity("Task.Models.Category", b =>
                {
                    b.Navigation("Works");
                });
#pragma warning restore 612, 618
        }
    }
}
