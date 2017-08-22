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

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class InstitutionControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            InstitutionController controller = new InstitutionController(new InstitutionService(), new OrgService());

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
            InstitutionController controller = new InstitutionController(new InstitutionService(), new OrgService());

            // Act
            ViewResult result = controller.Index2() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Institution model = result.Model as Institution;
            Assert.AreEqual("ORG !!!! Institution", model.Name);

        }

    }
}
