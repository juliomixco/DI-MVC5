using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public class InstitutionService : IInstitutionService
    {
        public Institution GetInstitutionByID(long institutionID)
        {
            return new Institution { InstitutionID = institutionID, Name = "Sample Institution", Address = "Sample Address", Telephone = "0123456789" };
        }
    }
}