using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class InstitutionController : Controller
    {
        //[Dependency("institution")]
        //public IInstitutionService institutionService { get; set; }
        //[Dependency("org")]
        //public IInstitutionService orgService { get; set; }

        private IInstitutionService institutionService;
        private IInstitutionService orgService;

        public InstitutionController(IInstitutionService institutionService, IInstitutionService orgService)
        {
            this.institutionService = institutionService;
            this.orgService = orgService;
        }

        // GET: Institution
        public ActionResult Index()
        {
            return View(this.institutionService.GetInstitutionByID(1));
        }
        public ActionResult Index2()
        {
            return View("Index", this.orgService.GetInstitutionByID(1));
        }
    }
}