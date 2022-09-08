using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsInstituteMsts :Entity
    {
        public int InstituteCd { get; set; }
        public string InstituteName { get; set; }
        public string InstituteType { get; set; }
        public string UniversityId { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDatetime { get; set; }
    }
}
