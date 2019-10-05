using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTOSQL
{
    public class QL_NguoiDung
    {
        QLCHBANTRASUADataContext qlts = new QLCHBANTRASUADataContext();
        public List<AccountD> loadTS()
        {
            return qlts.AccountDs.Select(t => t).ToList<AccountD>();
        }
        

    }
    
}
