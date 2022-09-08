using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsEnrollDoc :Entity
    {
        public string VtCode { get; set; }
        public int? UnitCode { get; set; }
        public byte[] VtPhoto { get; set; }
        public string VtIdType { get; set; }
        public string VtIdDtl { get; set; }
        public byte[] VtIdUpload { get; set; }
        public string DecFlag { get; set; }
        public string CertFlag { get; set; }
        public string UndertakingFlag { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
