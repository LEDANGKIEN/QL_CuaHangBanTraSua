using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LINQTOSQL;
using System.Data.Linq;
namespace DTO
{
    class AccountD1
    {
        QLCHBANTRASUADataContext db = new QLCHBANTRASUADataContext();
        private string userName;
        private string displayName;
        private string password;
        private int idTypeAccount;
        public AccountD1(string userName, string displayName, string password, int idTypeAccount)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.IdTypeAccount = idTypeAccount;
        }
        public AccountD1(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Password = row["password"].ToString();
            this.IdTypeAccount = (int)row["idTypeAccount"];
        }
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string DisplayName
        {
            get
            {
                return displayName;
            }

            set
            {
                displayName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int IdTypeAccount
        {
            get
            {
                return idTypeAccount;
            }

            set
            {
                idTypeAccount = value;
            }
        }
    }
}
