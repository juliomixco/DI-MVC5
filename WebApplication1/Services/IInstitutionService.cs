using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public interface IInstitutionService
    {
        Institution GetInstitutionByID(long institutionID);
    }
}