﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopCuaTui.Models;

namespace ShopCuaTui.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopCuaTui.Models.HangHoa", b =>
                {
                    b.Property<int>("MaHh")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DonGia");

                    b.Property<int>("GiamGia");

                    b.Property<int>("MaLoai");

                    b.Property<string>("MaTh")
                        .HasMaxLength(50);

                    b.Property<string>("MoTa");

                    b.Property<string>("ProductImg");

                    b.Property<string>("SingleProductImg1")
                        .HasMaxLength(150);

                    b.Property<string>("SingleProductImg2")
                        .HasMaxLength(150);

                    b.Property<string>("SingleProductImg3")
                        .HasMaxLength(150);

                    b.Property<string>("SingleProductImg4")
                        .HasMaxLength(150);

                    b.Property<int>("SoLuong");

                    b.Property<string>("TenHh")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("MaHh");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaTh");

                    b.ToTable("HangHoas");
                });

            modelBuilder.Entity("ShopCuaTui.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKh")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("DiaChi")
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("HoLot")
                        .HasMaxLength(150);

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaKh");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("ShopCuaTui.Models.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hinh")
                        .HasMaxLength(150);

                    b.Property<int?>("MaLoaiCha");

                    b.Property<string>("MoTa");

                    b.Property<string>("TenLoai")
                        .HasMaxLength(50);

                    b.HasKey("MaLoai");

                    b.HasIndex("MaLoaiCha");

                    b.ToTable("Loais");
                });

            modelBuilder.Entity("ShopCuaTui.Models.ThuongHieu", b =>
                {
                    b.Property<string>("MaTh")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("DiaChi")
                        .HasMaxLength(150);

                    b.Property<string>("DienThoai")
                        .HasMaxLength(50);

                    b.Property<string>("Logo")
                        .HasMaxLength(150);

                    b.Property<string>("MoTa");

                    b.Property<string>("TenThuongHieu")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaTh");

                    b.ToTable("ThuongHieus");
                });

            modelBuilder.Entity("ShopCuaTui.Models.HangHoa", b =>
                {
                    b.HasOne("ShopCuaTui.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShopCuaTui.Models.ThuongHieu", "ThuongHieu")
                        .WithMany()
                        .HasForeignKey("MaTh");
                });

            modelBuilder.Entity("ShopCuaTui.Models.Loai", b =>
                {
                    b.HasOne("ShopCuaTui.Models.Loai", "LoaiCha")
                        .WithMany()
                        .HasForeignKey("MaLoaiCha");
                });
#pragma warning restore 612, 618
        }
    }
}
