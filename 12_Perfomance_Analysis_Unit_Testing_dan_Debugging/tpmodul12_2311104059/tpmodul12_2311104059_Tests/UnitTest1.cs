using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104059;

namespace tpmodul12_2311104059_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNegatif()
        {
            var form = new Form1();
            Assert.AreEqual("Negatif", form.CariTandaBilangan(-5));
        }

        [TestMethod]
        public void TestNol()
        {
            var form = new Form1();
            Assert.AreEqual("Nol", form.CariTandaBilangan(0));
        }

        [TestMethod]
        public void TestPositif()
        {
            var form = new Form1();
            Assert.AreEqual("Positif", form.CariTandaBilangan(10));
        }
    }

}
