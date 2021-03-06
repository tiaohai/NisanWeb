﻿using HLGranite.Nisan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HLGranite.Nisan.Test
{
    
    
    /// <summary>
    ///This is a test class for NisanTest and is intended
    ///to contain all NisanTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NisanTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void InheritanceTest()
        {
            Stock stock = new Stock(3);
            Nisan target = new Nisan();            
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            Nisan target = new Nisan(new Stock(3));
            Stock stock = (Stock)target;
            target.Name = "Roslan bt Ismail";
            target.Death = new System.DateTime(2012, 6, 21);
            target.Deathm = new System.DateTime(1423, 7, 23);
            target.Save();
            Assert.IsTrue(target.Id > 0);
        }
    }
}
