using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKham.CQL
{
    [Serializable]
    internal class CBacSi
    {
        private string m_mabacsi;
        private string m_tenbacsi;
        private DateTime m_ngaysinh;
        private string m_sodienthoai;

        public string MaBacSi { get; set; }
        public string TenBacSi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public CBacSi() : this("", "", DateTime.Now, "") { }
        public CBacSi(string maBacSi, string tenBacSi, DateTime ngaySinh, string soDienThoai)
        {
            MaBacSi = maBacSi;
            TenBacSi = tenBacSi;
            NgaySinh = ngaySinh;
            SDT = soDienThoai;
        }

        public override string ToString()
        {
            return TenBacSi;
        }
    }
}
