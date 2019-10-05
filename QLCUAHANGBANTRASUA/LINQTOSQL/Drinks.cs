using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTOSQL
{
    public class Drinks
    {
        QLCHBANTRASUADataContext qlts = new QLCHBANTRASUADataContext();
        public List<Drink> loadTS()
        {
            return qlts.Drinks.Select(t => t).ToList<Drink>();
        }
    }
}
