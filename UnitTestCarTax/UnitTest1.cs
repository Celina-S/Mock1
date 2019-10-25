using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCarTax
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CarPrice_WherePriceIsLessThanNull_ShouldThrowArrgumentOutOfRange()
        {
            // Arrange
            int bil = 200;
            // Act
            try
            {
                Skat.Afgift.BilAfgift(bil);
                Assert.Fail("FAIL! the expected exception was not thrown");
            }
            catch(System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "Det er ikke muligt at beregne prisen bilen, da prisen enten er 0 eller i minus. Prøv igen!");
            }
        }
        //[TestMethod]
        //public void ElectricCarPrice_WherePriceIsLessThanNull_ShouldThrowArrgumentOutOfRange()
        //{
        //    // Arrange
        //    int bil = 200;
        //    // Act
        //    try
        //    {
        //        Skat.Afgift.ElBilAfgift(bil);
        //        Assert.Fail("FAIL! the expected exception was not thrown");
        //    }
        //    catch (System.ArgumentOutOfRangeException e)
        //    {
        //        // Assert
        //        StringAssert.Contains(e.Message, "Det er ikke muligt at beregne prisen bilen, da prisen enten er 0 eller i minus. Prøv igen!");
        //    }
        //}

        [TestMethod]
        public void ElectricCarPrice_WherePriceIsLessThanNull_ShouldThrowArrgumentOutOfRange()
        {
            // Arrange
            int bil = 200;
            // Act
            try
            {
                Skat.Afgift.ElBilAfgift(bil);
                Assert.Fail("FAIL! the expected exception was not thrown");
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "Det er ikke muligt at beregne prisen bilen, da prisen enten er 0 eller i minus. Prøv igen!");
            }
        }
    }
}
