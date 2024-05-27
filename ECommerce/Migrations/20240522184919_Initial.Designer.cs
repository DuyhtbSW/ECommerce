﻿// <auto-generated />
using System;
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Migrations
{
    [DbContext(typeof(Hshop2023Context))]
    [Migration("20240522184919_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerce.Data.BanBe", b =>
                {
                    b.Property<int>("MaBb")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaBB");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBb"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaHh")
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    b.Property<string>("MaKh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MaKH");

                    b.Property<DateTime>("NgayGui")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("MaBb")
                        .HasName("PK_Promotions");

                    b.HasIndex("MaHh");

                    b.HasIndex("MaKh");

                    b.ToTable("BanBe", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.ChiTietHd", b =>
                {
                    b.Property<int>("MaCt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaCT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCt"));

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<int>("MaHd")
                        .HasColumnType("int")
                        .HasColumnName("MaHD");

                    b.Property<int>("MaHh")
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    b.Property<int>("SoLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("MaCt")
                        .HasName("PK_OrderDetails");

                    b.HasIndex("MaHd");

                    b.HasIndex("MaHh");

                    b.ToTable("ChiTietHD", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.ChuDe", b =>
                {
                    b.Property<int>("MaCd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaCD");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCd"));

                    b.Property<string>("MaNv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNV");

                    b.Property<string>("TenCd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenCD");

                    b.HasKey("MaCd");

                    b.HasIndex("MaNv");

                    b.ToTable("ChuDe", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.GopY", b =>
                {
                    b.Property<string>("MaGy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaGY");

                    b.Property<bool>("CanTraLoi")
                        .HasColumnType("bit");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaCd")
                        .HasColumnType("int")
                        .HasColumnName("MaCD");

                    b.Property<DateOnly>("NgayGy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("NgayGY")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateOnly?>("NgayTl")
                        .HasColumnType("date")
                        .HasColumnName("NgayTL");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraLoi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaGy");

                    b.HasIndex("MaCd");

                    b.ToTable("GopY", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.HangHoa", b =>
                {
                    b.Property<int>("MaHh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHh"));

                    b.Property<double?>("DonGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<string>("Hinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaLoai")
                        .HasColumnType("int");

                    b.Property<string>("MaNcc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNCC");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTaDonVi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgaySx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("NgaySX")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("SoLanXem")
                        .HasColumnType("int");

                    b.Property<string>("TenAlias")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenHh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenHH");

                    b.HasKey("MaHh")
                        .HasName("PK_Products");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNcc");

                    b.ToTable("HangHoa", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.HoaDon", b =>
                {
                    b.Property<int>("MaHd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaHD");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHd"));

                    b.Property<string>("CachThanhToan")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Cash");

                    b.Property<string>("CachVanChuyen")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Airline");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaKh")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MaKH");

                    b.Property<string>("MaNv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNV");

                    b.Property<int>("MaTrangThai")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayCan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("NgayDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("NgayGiao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(((1)/(1))/(1900))");

                    b.Property<double>("PhiVanChuyen")
                        .HasColumnType("float");

                    b.HasKey("MaHd")
                        .HasName("PK_Orders");

                    b.HasIndex("MaKh");

                    b.HasIndex("MaNv");

                    b.HasIndex("MaTrangThai");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.HoiDap", b =>
                {
                    b.Property<int>("MaHd")
                        .HasColumnType("int")
                        .HasColumnName("MaHD");

                    b.Property<string>("CauHoi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaNv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNV");

                    b.Property<DateOnly>("NgayDua")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("TraLoi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaHd");

                    b.HasIndex("MaNv");

                    b.ToTable("HoiDap", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.KhachHang", b =>
                {
                    b.Property<string>("MaKh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MaKH");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<bool>("HieuLuc")
                        .HasColumnType("bit");

                    b.Property<string>("Hinh")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Photo.gif");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgaySinh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("RandomKey")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("VaiTro")
                        .HasColumnType("int");

                    b.HasKey("MaKh")
                        .HasName("PK_Customers");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoai"));

                    b.Property<string>("Hinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenLoaiAlias")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaLoai")
                        .HasName("PK_Categories");

                    b.ToTable("Loai", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.NhaCungCap", b =>
                {
                    b.Property<string>("MaNcc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNCC");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiLienLac")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenCongTy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaNcc")
                        .HasName("PK_Suppliers");

                    b.ToTable("NhaCungCap", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.NhanVien", b =>
                {
                    b.Property<string>("MaNv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNV");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaNv");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.PhanCong", b =>
                {
                    b.Property<int>("MaPc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaPC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPc"));

                    b.Property<bool?>("HieuLuc")
                        .HasColumnType("bit");

                    b.Property<string>("MaNv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MaNV");

                    b.Property<string>("MaPb")
                        .IsRequired()
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("MaPB");

                    b.Property<DateTime?>("NgayPc")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayPC");

                    b.HasKey("MaPc");

                    b.HasIndex("MaNv");

                    b.HasIndex("MaPb");

                    b.ToTable("PhanCong", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.PhanQuyen", b =>
                {
                    b.Property<int>("MaPq")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaPQ");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPq"));

                    b.Property<string>("MaPb")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("MaPB");

                    b.Property<int?>("MaTrang")
                        .HasColumnType("int");

                    b.Property<bool>("Sua")
                        .HasColumnType("bit");

                    b.Property<bool>("Them")
                        .HasColumnType("bit");

                    b.Property<bool>("Xem")
                        .HasColumnType("bit");

                    b.Property<bool>("Xoa")
                        .HasColumnType("bit");

                    b.HasKey("MaPq");

                    b.HasIndex("MaPb");

                    b.HasIndex("MaTrang");

                    b.ToTable("PhanQuyen", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.PhongBan", b =>
                {
                    b.Property<string>("MaPb")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("MaPB");

                    b.Property<string>("TenPb")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenPB");

                    b.Property<string>("ThongTin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPb");

                    b.ToTable("PhongBan", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.TrangThai", b =>
                {
                    b.Property<int>("MaTrangThai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TenTrangThai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaTrangThai");

                    b.ToTable("TrangThai", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.TrangWeb", b =>
                {
                    b.Property<int>("MaTrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTrang"));

                    b.Property<string>("TenTrang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("URL");

                    b.HasKey("MaTrang");

                    b.ToTable("TrangWeb", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.VChiTietHoaDon", b =>
                {
                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<double>("GiamGia")
                        .HasColumnType("float");

                    b.Property<int>("MaCt")
                        .HasColumnType("int")
                        .HasColumnName("MaCT");

                    b.Property<int>("MaHd")
                        .HasColumnType("int")
                        .HasColumnName("MaHD");

                    b.Property<int>("MaHh")
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHh")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenHH");

                    b.ToTable((string)null);

                    b.ToView("vChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.YeuThich", b =>
                {
                    b.Property<int>("MaYt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaYT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaYt"));

                    b.Property<int?>("MaHh")
                        .HasColumnType("int")
                        .HasColumnName("MaHH");

                    b.Property<string>("MaKh")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MaKH");

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NgayChon")
                        .HasColumnType("datetime");

                    b.HasKey("MaYt")
                        .HasName("PK_Favorites");

                    b.HasIndex("MaHh");

                    b.HasIndex("MaKh");

                    b.ToTable("YeuThich", (string)null);
                });

            modelBuilder.Entity("ECommerce.Data.BanBe", b =>
                {
                    b.HasOne("ECommerce.Data.HangHoa", "MaHhNavigation")
                        .WithMany("BanBes")
                        .HasForeignKey("MaHh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_QuangBa_HangHoa");

                    b.HasOne("ECommerce.Data.KhachHang", "MaKhNavigation")
                        .WithMany("BanBes")
                        .HasForeignKey("MaKh")
                        .HasConstraintName("FK_BanBe_KhachHang");

                    b.Navigation("MaHhNavigation");

                    b.Navigation("MaKhNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.ChiTietHd", b =>
                {
                    b.HasOne("ECommerce.Data.HoaDon", "MaHdNavigation")
                        .WithMany("ChiTietHds")
                        .HasForeignKey("MaHd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Orders");

                    b.HasOne("ECommerce.Data.HangHoa", "MaHhNavigation")
                        .WithMany("ChiTietHds")
                        .HasForeignKey("MaHh")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Products");

                    b.Navigation("MaHdNavigation");

                    b.Navigation("MaHhNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.ChuDe", b =>
                {
                    b.HasOne("ECommerce.Data.NhanVien", "MaNvNavigation")
                        .WithMany("ChuDes")
                        .HasForeignKey("MaNv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_ChuDe_NhanVien");

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.GopY", b =>
                {
                    b.HasOne("ECommerce.Data.ChuDe", "MaCdNavigation")
                        .WithMany("Gopies")
                        .HasForeignKey("MaCd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_GopY_ChuDe");

                    b.Navigation("MaCdNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.HangHoa", b =>
                {
                    b.HasOne("ECommerce.Data.Loai", "MaLoaiNavigation")
                        .WithMany("HangHoas")
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("ECommerce.Data.NhaCungCap", "MaNccNavigation")
                        .WithMany("HangHoas")
                        .HasForeignKey("MaNcc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Products_Suppliers");

                    b.Navigation("MaLoaiNavigation");

                    b.Navigation("MaNccNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.HoaDon", b =>
                {
                    b.HasOne("ECommerce.Data.KhachHang", "MaKhNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaKh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("ECommerce.Data.NhanVien", "MaNvNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_HoaDon_NhanVien");

                    b.HasOne("ECommerce.Data.TrangThai", "MaTrangThaiNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaTrangThai")
                        .IsRequired()
                        .HasConstraintName("FK_HoaDon_TrangThai");

                    b.Navigation("MaKhNavigation");

                    b.Navigation("MaNvNavigation");

                    b.Navigation("MaTrangThaiNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.HoiDap", b =>
                {
                    b.HasOne("ECommerce.Data.NhanVien", "MaNvNavigation")
                        .WithMany("HoiDaps")
                        .HasForeignKey("MaNv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HoiDap_NhanVien");

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.PhanCong", b =>
                {
                    b.HasOne("ECommerce.Data.NhanVien", "MaNvNavigation")
                        .WithMany("PhanCongs")
                        .HasForeignKey("MaNv")
                        .IsRequired()
                        .HasConstraintName("FK_PhanCong_NhanVien");

                    b.HasOne("ECommerce.Data.PhongBan", "MaPbNavigation")
                        .WithMany("PhanCongs")
                        .HasForeignKey("MaPb")
                        .IsRequired()
                        .HasConstraintName("FK_PhanCong_PhongBan");

                    b.Navigation("MaNvNavigation");

                    b.Navigation("MaPbNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.PhanQuyen", b =>
                {
                    b.HasOne("ECommerce.Data.PhongBan", "MaPbNavigation")
                        .WithMany("PhanQuyens")
                        .HasForeignKey("MaPb")
                        .HasConstraintName("FK_PhanQuyen_PhongBan");

                    b.HasOne("ECommerce.Data.TrangWeb", "MaTrangNavigation")
                        .WithMany("PhanQuyens")
                        .HasForeignKey("MaTrang")
                        .HasConstraintName("FK_PhanQuyen_TrangWeb");

                    b.Navigation("MaPbNavigation");

                    b.Navigation("MaTrangNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.YeuThich", b =>
                {
                    b.HasOne("ECommerce.Data.HangHoa", "MaHhNavigation")
                        .WithMany("YeuThiches")
                        .HasForeignKey("MaHh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_YeuThich_HangHoa");

                    b.HasOne("ECommerce.Data.KhachHang", "MaKhNavigation")
                        .WithMany("YeuThiches")
                        .HasForeignKey("MaKh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Favorites_Customers");

                    b.Navigation("MaHhNavigation");

                    b.Navigation("MaKhNavigation");
                });

            modelBuilder.Entity("ECommerce.Data.ChuDe", b =>
                {
                    b.Navigation("Gopies");
                });

            modelBuilder.Entity("ECommerce.Data.HangHoa", b =>
                {
                    b.Navigation("BanBes");

                    b.Navigation("ChiTietHds");

                    b.Navigation("YeuThiches");
                });

            modelBuilder.Entity("ECommerce.Data.HoaDon", b =>
                {
                    b.Navigation("ChiTietHds");
                });

            modelBuilder.Entity("ECommerce.Data.KhachHang", b =>
                {
                    b.Navigation("BanBes");

                    b.Navigation("HoaDons");

                    b.Navigation("YeuThiches");
                });

            modelBuilder.Entity("ECommerce.Data.Loai", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("ECommerce.Data.NhaCungCap", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("ECommerce.Data.NhanVien", b =>
                {
                    b.Navigation("ChuDes");

                    b.Navigation("HoaDons");

                    b.Navigation("HoiDaps");

                    b.Navigation("PhanCongs");
                });

            modelBuilder.Entity("ECommerce.Data.PhongBan", b =>
                {
                    b.Navigation("PhanCongs");

                    b.Navigation("PhanQuyens");
                });

            modelBuilder.Entity("ECommerce.Data.TrangThai", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("ECommerce.Data.TrangWeb", b =>
                {
                    b.Navigation("PhanQuyens");
                });
#pragma warning restore 612, 618
        }
    }
}
