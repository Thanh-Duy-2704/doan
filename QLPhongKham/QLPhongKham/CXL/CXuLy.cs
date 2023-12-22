using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKham.CXL
{
    public interface CXuly<XL>
    {
        List<XL> getALL();
        List<XL> getLike(string Ma);
        XL getMa(string Ma);

        Boolean them(XL obj);
        Boolean xoa(XL obj);
        Boolean sua(XL obj);
    }
}
