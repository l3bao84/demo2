using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    internal class NhanVien
    {
        private string manv { get; set; }
        private string hoten { get; set; }
        private DateTime ngaysinh { get; set; }
        private string gioitinh { get; set; }
        private string phongban { get; set; }
        private double hsLuong { get; set; }
        public NhanVien()
        {

        }
        public NhanVien(string manv, string hoten, DateTime ngaysinh, string gioitinh, string phongban, double hsLuong)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.phongban = phongban;
            this.hsLuong = hsLuong;
        }

        public int tinhTuoi(int x)
        {
            return this.ngaysinh.Year - x;
        }
    }
}
