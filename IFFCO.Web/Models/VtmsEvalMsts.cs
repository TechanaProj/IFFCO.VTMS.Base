using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsEvalMsts :Entity
    {
        public string EvalCatId { get; set; }
        public string EvalCatDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDatetime { get; set; }
        public string Status { get; set; }
    }
}
