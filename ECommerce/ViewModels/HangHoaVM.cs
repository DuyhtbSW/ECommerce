﻿namespace ECommerce.ViewModels
{
    public class HangHoaVM
    {
        public int MaHH { get; set; }
        public string? TenHH { get; set; }
        public string? Hinh { get; set; }
        public double DonGia { get; set; }
        public string? MoTa { get; set; }
        public string? TenLoai { get; set; }
    }
    public class HangHoaDetailVM
    {
        public int MaHH { get; set; }
        public string? TenHH { get; set; }
        public string? Hinh { get; set; }
        public double DonGia { get; set; }
        public string? MoTa { get; set; }
        public string? TenLoai { get; set; }
        public string? ChiTiet { get; set; }
        public int DiemDanhGia { get; set; }
        public int SoLuongTon { get; set; }
    }
    public class CardItem
    {
        public int MaHH { get; set; }
        public string? Hinh { get; set; }
        public string? TenHH { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien => SoLuong * DonGia;
    }

}
