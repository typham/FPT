using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Test
{
    [TestFixture]
    public class SimpleCaculatorTest
    {
        [Test]
        public void OnePlusOneEqualTwo()
        {
            Caculator cal = new Caculator();
            Assert.That(cal.plus(1, 1), Is.EqualTo(2));
        }

        [Test]
        public void TwoMinusOneEqualOne()
        {
            Caculator cal = new Caculator();
            Assert.That(cal.minus(2, 1), Is.EqualTo(1));
        }
    }
}
