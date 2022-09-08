using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsCourseMsts :Entity
    {
        public long CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}
