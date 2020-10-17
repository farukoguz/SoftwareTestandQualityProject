using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazılımMuhendisligi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi.Tests
{
    [TestClass()]
    public class TicketTests
    {
        double p;

        [TestInitialize()]
        public void TestInitialize()
        {
            p = -15;
        }

        [TestMethod()]
        public void TicketTest()
        {         
            Ticket t = new Ticket(p);
            Assert.AreEqual(p, t.NetPrice);
        }
    }
}