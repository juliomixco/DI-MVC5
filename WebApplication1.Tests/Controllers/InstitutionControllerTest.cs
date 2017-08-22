using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Controllers;
using WebApplication1.Services;
using WebApplication1.Entities;
using Microsoft.Practices.Unity;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class InstitutionControllerTest
    {
        private InstitutionController getInstitutionControllerInstance() {
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

            return container.Resolve<InstitutionController>();
        } 
        [TestMethod]
        public void Index()
        {
            // Arrange
            InstitutionController controller = getInstitutionControllerInstance();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Institution model = result.Model as Institution;
            Assert.AreEqual("Sample Institution", model.Name);

        }

        [TestMethod]
        public void Index2_should_use_OrgService_instance()
        {
            // Arrange
            InstitutionController controller = getInstitutionControllerInstance();

            // Act
            ViewResult result = controller.Index2() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Institution model = result.Model as Institution;
            Assert.AreEqual("ORG !!!! Institution", model.Name);

        }

    }
}
