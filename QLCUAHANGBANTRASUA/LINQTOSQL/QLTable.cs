using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTOSQL
{
    class QLTable
    {
        QLCHBANTRASUADataContext qlts = new QLCHBANTRASUADataContext();


    //    public List<QLCHBTRASUA> LoadQLCHBTRASUA()
    //    {
    //        return qlts.QLCHBTRASUA.Select(t => t).ToList<QLCHBTRASUA>();
    //    }

    //    public int KTKC_QLSDTS(string masd)
    //    {
    //        var kt = from sdts in qlts.QLSDTAISANs
    //                 where sdts.MASD == masd
    //                 select sdts.MASD;
    //        if (kt.Count() > 0)
    //        {
    //            return 1;
    //        }
    //        else
    //            return 0;
    //    }
    //    public int ThemQLSDTS(QLSDTAISAN qlsdts)
    //    {
    //        int flag = 1;
    //        try
    //        {
    //            qlts.QLSDTAISANs.InsertOnSubmit(qlsdts);
    //            qlts.SubmitChanges();
    //            flag = 1;
    //        }
    //        catch
    //        {
    //            flag = 0;
    //        }
    //        return flag;
    //    }
    //    public int XoaQLSDTS(string masd)
    //    {
    //        int flag = 1;
    //        try
    //        {
    //            QLSDTAISAN qlsd = qlts.QLSDTAISANs.Where(t => t.MASD == masd).FirstOrDefault();
    //            qlts.QLSDTAISANs.DeleteOnSubmit(qlsd);
    //            qlts.SubmitChanges();
    //            flag = 1;
    //        }
    //        catch
    //        {
    //            flag = 0;
    //        }
    //        return flag;
    //    }
    //    public int SuaQLSDTS(string masd, string mats, string mapb, int soluong, DateTime ngaysd, DateTime ngayht, string mucdich)
    //    {
    //        int flag = 1;
    //        try
    //        {
    //            QLSDTAISAN qlsd = qlts.QLSDTAISANs.Where(t => t.MASD == masd).FirstOrDefault();
    //            if (qlsd != null)
    //            {
    //                qlsd.MASD = masd;
    //                qlsd.MATS = mats;
    //                qlsd.MAPB = mapb;
    //                qlsd.SOLUONG = soluong;
    //                qlsd.NGAYSD = ngaysd;
    //                qlsd.NGAYHT = ngayht;

    //                qlsd.MUCDICH = mucdich;
    //                qlts.SubmitChanges();
    //            }
    //            flag = 1;

    //        }
    //        catch
    //        {
    //            flag = 0;
    //        }
    //        return flag;
    //    }
    }
}
