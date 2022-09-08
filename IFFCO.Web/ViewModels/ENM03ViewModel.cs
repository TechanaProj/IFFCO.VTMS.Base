using IFFCO.VTMS.Web.ViewModels;
using IFFCO.HRMS.Shared.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using IFFCO.VTMS.Web.Models;
using System;

namespace IFFCO.VTMS.Web.ViewModels
{
    public class ENM03ViewModel : BaseModel
    {
        public List<VtmsInstituteMsts> vtmsInstitiutelist { get; set; }
        public VtmsInstituteMsts vtmsInstitiute { get; set; }
        public int InstituteCd { get; set; }
        public string InstituteName { get; set; }
        public string InstituteType { get; set; }
        public List<SelectListItem> StateLOV { get; set; }
        public string StateName { get; set; }
        public List<SelectListItem> DistrictLOV { get; set; }
        public string DistrictName { get; set; }
        public List<SelectListItem> UniversityLOV { get; set; }
        public string UniversityId { get; set; }
        public decimal? UnitCode { get; set; }

    }

}
