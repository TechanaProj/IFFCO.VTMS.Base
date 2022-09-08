using IFFCO.VTMS.Web.ViewModels;
using IFFCO.HRMS.Shared.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using IFFCO.VTMS.Web.Models;
using System;

namespace IFFCO.VTMS.Web.ViewModels
{
    public class ENM05ViewModel : BaseModel
    {
        public List<VtmsRecommMsts> vtmsRecommendationlist { get; set; }
        public VtmsRecommMsts vtmsRecommendation { get; set; }
        public string RecommId { get; set; }
        public string RecommName { get; set; }
        public decimal? UnitCode { get; set; }
        public string Status { get; set; }

    }

}
