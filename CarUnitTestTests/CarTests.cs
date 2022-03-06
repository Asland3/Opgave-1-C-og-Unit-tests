using System;
using CarUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarUnitTestTests
{
    [TestClass()]
    public class CarTests
    {
        private Car _car;

        [TestInitialize]
        public void SetUp()
        {
            _car = new Car(100, "Toyota", 500000, "BK75590");
        }

        [TestMethod()]
        public void ModelTest()
        {
            Assert.AreEqual("Toyota", _car.Model);
            Assert.ThrowsException<ArgumentNullException>(() => _car.Model = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Model = "BMW");
        }

        [TestMethod()]
        public void PriceTest()
        {
            _car.Price = 50;
            Assert.AreEqual(50, _car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = -1);
        }

        [TestMethod()]
        public void LicensePlateTest()
        {
            _car.LicensePlate = "BD75590";
            Assert.AreEqual("BD75590", _car.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.LicensePlate = "a");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.LicensePlate = "abcd265989");
            Assert.ThrowsException<ArgumentNullException>(() => _car.LicensePlate = null);
        }


    }
}