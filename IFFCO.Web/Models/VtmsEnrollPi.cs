using IFFCO.HRMS.Repository.Pattern;
using System;
using System.Collections.Generic;

namespace IFFCO.VTMS.Web.Models
{
    public partial class VtmsEnrollPi :Entity
    {
        public string VtCode { get; set; }
        public long UnitCode { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long? ContactNo { get; set; }
        public string Address { get; set; }
        public string DistrictName { get; set; }
        public string StateName { get; set; }
        public long? Pincode { get; set; }
        public string DocName { get; set; }
        public string DocRegistrationNo { get; set; }
        public string RecommendationType { get; set; }
        public string OthersRecommName { get; set; }
        public long? RecommPno { get; set; }
        public DateTime? VtStartDate { get; set; }
        public DateTime? VtEndDate { get; set; }
        public string Status { get; set; }
        public string EnrollmentStatus { get; set; }
        public long? EnrolledBy { get; set; }
        public DateTime? EnrolledOn { get; set; }
        public long? ManagedBy { get; set; }
        public DateTime? ManagedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string PrevVtCode { get; set; }
    }
}
