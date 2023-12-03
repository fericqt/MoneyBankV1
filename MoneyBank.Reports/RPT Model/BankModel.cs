using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.Reports.RPT_Model {
    internal class BankModel {
        public int IdTrack { get; set; }
        public DateTime DateReference { get; set; }
        public string BankName { get; set; }
        public string BankSwiftcode { get; set; }
        public string BankLocation { get; set; }
        public string BankProvider { get; set; }
    }
}
