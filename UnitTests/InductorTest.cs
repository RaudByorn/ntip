using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class InductorTest
    {
        [Test]
        [TestCase(0, TestName ="[+] Positive Inductor Test l=0")]
        [TestCase(1, TestName = "[+] Positive Inductor Test l=1")]
        [TestCase(1.5, TestName = "[+] Positive Inductor Test l=1.5")]
        public void InductorPositiveTest(double l)
        {
            var unused = new IComponent.Inductor(l);
        }

        [Test]
        [TestCase(-1, TestName = "[-] Negative Inductor Test l=-1")]
        [TestCase(-1.5, TestName = "[-] Negative Inductor Test l=-1.5")]
        [TestCase(-0.000001, TestName = "[-] Negative Inductor Test l=0.000001")]
        public void InductorNegativeTest(double l)
        {
            NUnit.Framework.Assert.That(() =>
            {
                var unused = new IComponent.Inductor(l);
            }, Throws.TypeOf(typeof(ArgumentException)));
        }

    }
}
