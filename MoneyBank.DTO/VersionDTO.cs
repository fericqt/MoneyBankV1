using FerPROJ.Design.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBank.DTO
{
    public class VersionDTO : CValidator
    {
        public long IdTrack { get; set; }
        public string NewUpdates { get; set; }
        public string OldUpdates { get; set; }
        public string Version { get; set; }
        public DateTime DateUpdated => DateTime.Now;
        public DateTime LastUpdatedOn { get; set; }

        public override bool DataValidation()
        {
            throw new NotImplementedException();
        }
    }
}
