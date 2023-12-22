using QLPhongKham.CQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKham.CXL
{
    [Serializable]
    internal class CXulyT : CXuly<CThuoc>
    {
        private List<CThuoc> dsT;
        public CXulyT()
        {
            dsT = CTruyCapDuLieu.khoiTao().DST;
        }

        public CXulyT(CXulyT xl)
        {
            this.dsT = xl.dsT.ToList();
        }

        public CXulyT(List<CThuoc> t)
        {
            this.dsT = t;
        }

        public List<CThuoc> getALL()
        {
            return dsT;
        }

        public CThuoc getMa(string Ma)
        {
            for (int i = 0; i < dsT.Count; i++)
            {
                if (dsT[i].MaThuoc == Ma)
                    return dsT[i];
            }
            return null;
        }

        public List<CThuoc> getLike(string Ma)
        {
            List<CThuoc> t = new List<CThuoc>();
            for (int i = 0; i < dsT.Count; i++)
            {
                if (dsT[i].MaThuoc.Contains(Ma))
                    t.Add(dsT[i]);
            }
            return t;
        }

        public Boolean them(CThuoc obj)
        {
            if (getMa(obj.MaThuoc) == null)
            {
                dsT.Add(obj);
                return true;
            }
            else
            {
                MessageBox.Show(" Mã tồn tại! ");
                return false;
            }
        }

        public Boolean xoa(CThuoc obj)
        {
            if (obj != null)
            {
                dsT.Remove(obj);
                return true;
            }
            return false;
        }
        public Boolean sua(CThuoc obj)
        {
            CThuoc _obj = getMa(obj.MaThuoc);
            if (_obj != null)
            {
                _obj.TacDung = obj.TacDung;
                _obj.TenThuoc = obj.TenThuoc;
                _obj.LieuDung = obj.LieuDung;
                _obj.CachDung = obj.CachDung;
                _obj.LoaiThuoc = obj.LoaiThuoc;
                return true;
            }
            return false;
        }
    }
}

