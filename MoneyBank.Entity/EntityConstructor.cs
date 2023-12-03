using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Entity
{
    public partial class moneybankEntities : DbContext
    {
        public moneybankEntities()
            : base("name=moneybankEntities") {
            Database.Connection.ConnectionString = CStaticVariable.mainConnection;
        }
    }
}
