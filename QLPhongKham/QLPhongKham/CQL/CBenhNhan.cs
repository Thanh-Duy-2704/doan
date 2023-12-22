using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKham.CQL
{
    [Serializable]
    internal class CBenhNhan
    {
        private string m_mabenhnhan;
        private string m_tenbenhnhan;
        private DateTime m_ngaysinh;
        private string m_gioitinh;
        private string m_sodienthoai;
        private string m_diachi;

        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public CBenhNhan() : this("", "", DateTime.Now, "", "", "") { }
        public CBenhNhan(string maBenhNhan, string tenBenhNhan, DateTime ngaySinh, string gioiTinh, string soDienThoai, string diaChi)
        {
            MaBenhNhan = maBenhNhan;
            TenBenhNhan = tenBenhNhan;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
        }

        public override string ToString()
        {
            return TenBenhNhan;
        }
    }
}
