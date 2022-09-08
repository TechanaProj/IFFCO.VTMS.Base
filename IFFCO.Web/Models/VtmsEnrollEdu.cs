using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsEnrollEdu :Entity
    {
        public string VtCode { get; set; }
        public long UnitCode { get; set; }
        public string CourseName { get; set; }
        public long? Year { get; set; }
        public long? Semester { get; set; }
        public string BranchName { get; set; }
        public string InstituteName { get; set; }
        public string UniversityName { get; set; }
        public long? EnrolledBy { get; set; }
        public DateTime? EnrolledOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string PrevVtCode { get; set; }
    }
}
