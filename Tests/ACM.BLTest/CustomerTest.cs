using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            var customer = new Customer
            {
                FirstName = "Jose",
                LastName = "Juarez"
            };
            string expected = "Juarez, Jose";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            var customer = new Customer
            {
                LastName = "Juarez"
            };
            string expected = "Juarez";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            var customer = new Customer
            {
                FirstName = "Jose"
            };
            string expected = "Jose";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer
            {
                FirstName = "Jose"
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Juan"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Pedro"
            };
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
