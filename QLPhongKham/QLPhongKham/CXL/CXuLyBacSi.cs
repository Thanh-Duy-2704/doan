using QLPhongKham.CQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKham.CXL
{
    internal class CXuLyBS : CXuly<CBacSi>
    {
        private List<CBacSi> dsBS;

        public CXuLyBS()
        {
            dsBS = CTruyCapDuLieu.khoiTao().DSBS;
        }

        public List<CBacSi> getALL()
        {
            return dsBS;
        }

        public CBacSi getMa(string Ma)
        {
            for (int i = 0; i < dsBS.Count; i++)
            {
                if (dsBS[i].MaBacSi == Ma)
                    return dsBS[i];
            }
            return null;
        }

        public List<CBacSi> getLike(string Ma)
        {
            List<CBacSi> bs = new List<CBacSi>();
            for (int i = 0; i < dsBS.Count; i++)
            {
                if (dsBS[i].MaBacSi.Contains(Ma))
                    bs.Add(dsBS[i]);
            }
            return bs;
        }

        public Boolean them(CBacSi obj)
        {
            if (getMa(obj.MaBacSi) == null)
            {
                dsBS.Add(obj);
                return true;
            }
            else
            {
                MessageBox.Show(" Mã tồn tại! ");
                return false;
            }
        }
        public Boolean sua(CBacSi obj)
        {
            CBacSi _obj = getMa(obj.MaBacSi);
            if (_obj != null)
            {
                _obj.MaBacSi = obj.MaBacSi;
                _obj.TenBacSi = obj.TenBacSi;
                _obj.NgaySinh = obj.NgaySinh;
                _obj.SDT = obj.SDT;
                return true;
            }
            return false;
        }

        public Boolean xoa(CBacSi obj)
        {
            if (obj != null)
            {
                dsBS.Remove(obj);
                return true;
            }
            return false;
        }
    }
}
