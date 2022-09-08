using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsEvalDtl :Entity
    {
        public string EvalId { get; set; }
        public string EvalCategory { get; set; }
        public string EvalParameters { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDatetime { get; set; }
        public string Status { get; set; }
    }
}
