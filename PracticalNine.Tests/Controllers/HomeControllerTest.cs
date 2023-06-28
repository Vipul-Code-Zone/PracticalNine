using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticalNine;
using PracticalNine.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace PracticalNine.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void Index()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void Test3()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Test3() as ViewResult;

			// Assert
			Assert.AreEqual("Hello World", result.ViewBag.Message);
		}

		[TestMethod]
		public void Contact()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Contact() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
