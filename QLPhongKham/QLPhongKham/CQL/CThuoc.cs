using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKham.CQL
{
    [Serializable]
    internal class CThuoc
    {
        private string m_mathuoc;
        private string m_tenthuoc;
        private string m_tacdung;
        private string m_lieudung;
        private string m_cachdung;
        private CLoaiThuoc m_loaithuoc;

        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string TacDung { get; set; }
        public string LieuDung { get; set; }
        public string CachDung { get; set; }
        public CLoaiThuoc LoaiThuoc { get; set; }
        public CThuoc() : this("", "", "", "", "", null) { }
        public CThuoc(string maThuoc, string tenThuoc, string tacDung, string lieuDung, string cachDung, CLoaiThuoc loaiThuoc)
        {
            MaThuoc = maThuoc;
            TenThuoc = tenThuoc;
            TacDung = tacDung;
            LieuDung = lieuDung;
            CachDung = cachDung;
            LoaiThuoc = loaiThuoc;
        }
    }
}

