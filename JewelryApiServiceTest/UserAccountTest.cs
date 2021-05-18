using JewelryApiService.DAL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace JewelryApiServiceTest
{
    [TestClass]
    public class UserAccountTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var paymentServiceMock = new Mock<iUserAccountDAL>();
        }
    }
}
