using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        [TestMethod]
        public void GivesComputerDiscount()
        {
            Computer xps = new Computer("Windows", "i7", 799, "Dell XPS 13");
            xps.GiveDiscount();
            Assert.AreEqual(759.05, xps.RetailCost, .001);
        }

        [TestMethod]
        public void GivesLaptopDiscount()
        {
            Laptop xps = new Laptop(50, "Windows", "i7", 799, "Dell XPS 13");
            xps.GiveDiscount();
            Assert.AreEqual(759.05, xps.RetailCost, .001);
        }

        [TestMethod]
        public void AssignsLaptopID()
        {
            Laptop xps = new Laptop(50, "Windows", "i7", 799, "Dell XPS 13");
            Assert.AreEqual("Dell XPS 13-1", xps.id);
        }

        [TestMethod]
        public void ChecksLaptopTemperature()
        {
            Laptop xps = new Laptop(100, "Windows", "i7", 799, "Dell XPS 13");
            Assert.IsTrue(xps.isHddOverheated());
        }

        [TestMethod]
        public void AssignsSmartphoneID()
        {
            Smartphone modelX = new Smartphone(true, "Android", "Snapdragon 990", 499, "ModelX");
            Assert.AreEqual("ModelX-2", modelX.id);
        }

        [TestMethod]
        public void GivesSmartphoneDiscount()
        {
            Smartphone modelX = new Smartphone(true, "Android", "Snapdragon 990", 499, "ModelX");
            modelX.GiveDiscount();
            Assert.AreEqual(474.05, modelX.RetailCost, .001);
        }

        [TestMethod]
        public void PrintsCompassStatment()
        {
            Smartphone modelX = new Smartphone(true, "Android", "Snapdragon 990", 499, "ModelX");
            try
            {
                modelX.PrintCompassSpec();
                return; // indicates success
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
