using IFFCO.HRMS.Repository.Pattern.Core.Factories;
using IFFCO.HRMS.Repository.Pattern.UnitOfWork;
using IFFCO.HRMS.Shared.CommonFunction;
using IFFCO.VTMS.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IFFCO.VTMS.Web.CommonFunctions
{
    public class DropDownListBindWeb : DropDownListBind
    {
        private readonly IRepositoryProvider _repositoryProvider = new RepositoryProvider(new RepositoryFactories());

        private readonly IUnitOfWorkAsync _unitOfWork;

        //IDataContextAsync context;
        private readonly ModelContext _context;
        DataTable _dt = new DataTable();
        public DropDownListBindWeb()
        {
            _context = new ModelContext();
        }

        public List<SelectListItem> UniversityLOVBind()
        {
            var UniversityLOV = _context.VtmsUniversityMsts.OrderBy(x=>x.UniversityId).Select(x => new SelectListItem
            {
                Text = string.Concat(x.UniversityId, " - ", x.UniversityName),
                Value = x.UniversityId.ToString()

            }).ToList();

            return UniversityLOV;
        }

        public List<SelectListItem> StateLOVBind()
        {
            var StateLOV = _context.MState.OrderBy(x=>x.StateName).Select(x => new SelectListItem
            {
                Text = string.Concat(x.StateCd, " - ", x.StateName),
                Value = x.StateCd.ToString()

            }).ToList();

            return StateLOV;
        }

        public List<SelectListItem> DistrictLOVBind()
        {
            var DistrictLOV = _context.MDistrict.OrderBy(x => x.DisttCd).Select(x => new SelectListItem
            {
                Text = string.Concat(x.DisttCd, " - ", x.DisttName),
                Value = x.DisttCd.ToString()

            }).ToList();

            return DistrictLOV;
        }

        public List<SelectListItem> GET_Review()
        {
            var Status = new List<SelectListItem>();
            Status = new List<SelectListItem>();
            Status.Add(new SelectListItem { Text = "--Select--", Value = "" });
            Status.Add(new SelectListItem { Text = "Excellent", Value = "Excellent" });
            Status.Add(new SelectListItem { Text = "Good", Value = "Good" });
            Status.Add(new SelectListItem { Text = "Average", Value = "Average" });
            Status.Add(new SelectListItem { Text = "Not Applicable", Value = "Not Applicable" });

            return Status;

        }

        public List<SelectListItem> GET_VTSTATUS()  
        {
            var Status = new List<SelectListItem>();
            Status = new List<SelectListItem>();
            Status.Add(new SelectListItem { Text = "--Select--", Value = "" });
            Status.Add(new SelectListItem { Text = "A - Active", Value = "A" });
            Status.Add(new SelectListItem { Text = "I - In-Active", Value = "I" });
            return Status;
        }

    }
}
