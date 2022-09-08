using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsRecommMsts :Entity
    {
        public string RecommId { get; set; }
        public string RecommName { get; set; }
        public decimal? UnitCode { get; set; }
        public string Status { get; set; }
    }
}
