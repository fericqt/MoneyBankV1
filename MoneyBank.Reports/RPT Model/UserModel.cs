using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    public class UserModel {
        public DateTime DateReference { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string UserId { get; set; }

        public DateTime DateLastLogin { get; set; }

        public string UserLevel { get; set; }
    }
}
