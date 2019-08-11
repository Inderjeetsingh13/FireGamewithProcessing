using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGamewithProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGamewithProcessing.Tests
{
    [TestClass()]
    public class fireTests
    {
        [TestMethod()]
        public void fireGunTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void playTest()
        {
            fire instance = new fire();
            instance.play();
            Assert.Fail();

        }

        [TestMethod()]
        public void fireTest()
        {
            fire instance = new fire();
            instance.fireGun();
            Assert.Fail();

        }



    }
}