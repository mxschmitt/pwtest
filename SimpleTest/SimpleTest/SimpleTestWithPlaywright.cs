using Microsoft.Playwright;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    [TestClass]
    public class SimpleTestWithPlaywright
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            using (var instance = await Playwright.CreateAsync())
            {
                Assert.AreEqual(1, 1);
            }
        }
    }
}
