using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using WebApplication1.Services;
using WebApplication1.Controllers;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICourseService, CourseService>();
            container.RegisterType<IInstitutionService, InstitutionService>("institution");
            container.RegisterType<IInstitutionService, OrgService>("org");

            container.RegisterType<InstitutionController>(
                new InjectionConstructor(
                    new ResolvedParameter<IInstitutionService>("institution"),
                new ResolvedParameter<IInstitutionService>("org")
                ));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}