using QLPhongKham.CQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKham.CXL
{
    internal class CXuLyBN : CXuly<CBenhNhan>
    {
        private List<CBenhNhan> dsBN;
        public CXuLyBN()
        {
            dsBN = CTruyCapDuLieu.khoiTao().DSBN;
        }
        public List<CBenhNhan> getALL()
        {
            return dsBN;
        }

        public CBenhNhan getMa(string Ma)
        {
            for (int i = 0; i < dsBN.Count; i++)
            {
                if (dsBN[i].MaBenhNhan == Ma)
                    return dsBN[i];
            }
            return null;
        }

        public List<CBenhNhan> getLike(string Ma)
        {
            List<CBenhNhan> bn = new List<CBenhNhan>();
            for (int i = 0; i < dsBN.Count; i++)
            {
                if (dsBN[i].MaBenhNhan.Contains(Ma))
                    bn.Add(dsBN[i]);
            }
            return bn;
        }

        public Boolean them(CBenhNhan obj)
        {
            if (getMa(obj.MaBenhNhan) == null)
            {
                dsBN.Add(obj);
                return true;
            }
            else
            {
                MessageBox.Show(" Mã tồn tại! ");
                return false;
            }
        }

        public Boolean xoa(CBenhNhan obj)
        {
            if (obj != null)
            {
                dsBN.Remove(obj);
                return true;
            }
            return false;
        }
        public Boolean sua(CBenhNhan obj)
        {
            CBenhNhan _obj = getMa(obj.MaBenhNhan);
            if (_obj != null)
            {
                _obj.MaBenhNhan = obj.MaBenhNhan;
                _obj.TenBenhNhan = obj.TenBenhNhan;
                _obj.NgaySinh = obj.NgaySinh;
                _obj.GioiTinh = obj.GioiTinh;
                _obj.SoDienThoai = obj.SoDienThoai;
                _obj.DiaChi = obj.DiaChi;
                return true;
            }
            return false;
        }
    }
}
