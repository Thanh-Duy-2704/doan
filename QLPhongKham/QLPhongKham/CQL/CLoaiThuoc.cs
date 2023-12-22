using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKham.CQL
{
    [Serializable]
    internal class CLoaiThuoc
    {
        private string m_maloaithuoc;
        private string m_tenloaithuoc;
        public string MaLoaiThuoc { get; set; }
        public string TenLoaiThuoc { get; set; }
        public CLoaiThuoc() : this("", "") { }
        public CLoaiThuoc(string maLoaiThuoc, string tenLoaiThuoc)
        {
            MaLoaiThuoc = maLoaiThuoc;
            TenLoaiThuoc = tenLoaiThuoc;
        }

        public override string ToString()
        {
            return TenLoaiThuoc;
        }
    }
}
