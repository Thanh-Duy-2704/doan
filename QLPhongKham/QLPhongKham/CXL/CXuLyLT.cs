using QLPhongKham.CQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKham.CXL
{
    internal class CXuLyLT : CXuly<CLoaiThuoc>
    {
        private List<CLoaiThuoc> dsLT;

        public CXuLyLT()
        {
            dsLT = CTruyCapDuLieu.khoiTao().DSLT;
        }

        public List<CLoaiThuoc> getALL()
        {
            return dsLT;
        }

        public CLoaiThuoc getMa(string Ma)
        {
            for (int i = 0; i < dsLT.Count; i++)
            {
                if (dsLT[i].MaLoaiThuoc == Ma)
                    return dsLT[i];
            }
            return null;
        }

        public List<CLoaiThuoc> getLike(string Ma)
        {
            List<CLoaiThuoc> lt = new List<CLoaiThuoc>();
            for (int i = 0; i < dsLT.Count; i++)
            {
                if (dsLT[i].MaLoaiThuoc.Contains(Ma))
                    lt.Add(dsLT[i]);
            }
            return lt;
        }

        public Boolean them(CLoaiThuoc obj)
        {
            if (getMa(obj.MaLoaiThuoc) == null)
            {
                dsLT.Add(obj);

                return true;
            }
            else
            {
                MessageBox.Show(" Mã tồn tại! ");
                return false;
            }
        }

        public Boolean xoa(CLoaiThuoc obj)
        {
            if (obj != null)
            {
                dsLT.Remove(obj);
                return true;
            }
            return false;
        }
        public Boolean sua(CLoaiThuoc obj)
        {
            CLoaiThuoc _obj = getMa(obj.MaLoaiThuoc);
            if (_obj != null)
            {
                _obj.MaLoaiThuoc = obj.MaLoaiThuoc;
                _obj.TenLoaiThuoc = obj.TenLoaiThuoc;
                return true;
            }
            return false;
        }
    }
}
