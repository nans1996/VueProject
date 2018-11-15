using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompStore.Controllers.DAOController;
using System.Web.Mvc;
using CompStore.Models.Test.Abstract;
using CompStore.Models.Test;
using Moq;
using CompStore;
using System.Collections.Generic;
using CompStore.Controllers;

namespace CompStoreTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void IndexViewModelNotNull()
        {
            int page = 10;
            //var mock = new Mock<IComputerRepository>();
            //mock.Setup(a => a.GetAllProduct()).Returns(new List<Product>());
            
            IComputerRepository repository = new InMemoryComputerRepository();
          //  ProductController controller = new ProductController(repository);

            //var result = controller.Index(page) as ViewResult;
            //Assert.AreEqual("Index",result.ViewName);

        }

        [TestMethod]
        public void Index_Render_View()
        {
            HomeController contr = new HomeController();
            var result = contr.Index();
            Assert.IsNotNull(result, "Визуализация не выполняется");
            Assert.AreEqual("Index",result.ViewName);

        }


    }
}
