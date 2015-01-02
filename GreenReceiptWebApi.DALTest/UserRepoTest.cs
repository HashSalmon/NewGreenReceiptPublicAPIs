using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenReceiptWebApi.DAL.RepositoryInterface;
using GreenReceiptWebApi.DAL.Repositories;
using Moq;
using GreenReceiptWebApi.DAL.UnitOfWorkInterface;
using GreenReceiptWebApi.DAL.Model;

namespace GreenReceiptWebApi.DALTest
{
    /// <summary>
    /// Summary description for UserRepoTest
    /// </summary>
    [TestClass]
    public class UserRepoTest
    {
        private IUserRepository userRepo;

        public UserRepoTest()
        {
            userRepo = new Mock<IUserRepository>().Object;
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void User_Create()
        {
            var newUser = new User() {UserId = 1, FirstName = "Jinggong", LastName = "Zheng", Password = "123", Email = "Test@example.com", Username = "kingsleyzheng"};

            userRepo.Create(newUser);
        }
    }
}
