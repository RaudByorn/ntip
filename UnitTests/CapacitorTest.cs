using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class CapacitorTest
    {
        [Test]
        [TestCase(0, TestName = "[+] Positive Capasitor Test l=0")]
        [TestCase(1, TestName = "[+] Positive Capasitor Test l=1")]
        [TestCase(1.5, TestName = "[+] Positive Capasitor Test l=1.5")]
        public void CapasitorPositiveTest(double c)
        {
            var unused = new IComponent.Capacitor(c);
        }

        [Test]
        [TestCase(-1, TestName = "[-] Negative Capasitor Test l=-1")]
        [TestCase(-1.5, TestName = "[-] Negative Capasitor Test l=-1.5")]
        [TestCase(-0.000001, TestName = "[-] Negative Capasitor Test l=0.000001")]
        public void CapasitorNegativeTest(double c)
        {
            NUnit.Framework.Assert.That(() =>
            {
                var unused = new IComponent.Capacitor(c);
            }, Throws.TypeOf(typeof(ArgumentException)));
        }
    }
}
