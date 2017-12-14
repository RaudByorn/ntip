using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ResistorTest
    {
        [Test]
        [TestCase(0, TestName = "[+] Positive Resistor Test R = 0")]
        [TestCase(1, TestName ="[+] Positive Resistor Test R = 1")]
        [TestCase(1.5, TestName = "[+] Positive Resistor Test R = 1.5")]
        public void ResistorPositiveTests(double r)
        {
            var unused = new IComponent.Resistor(r);
        }
        [Test]
        [TestCase(-1, TestName ="[-] Negative Resistor Test r=-1")]
        [TestCase(-1.5, TestName = "[-] Negative Resistor Test r=-1.5")]
        [TestCase(-0.000001, TestName = "[-] Negative Resistor Test r=0.000001")]
        public void ResistorNegativeTests(double r)
        {
            NUnit.Framework.Assert.That(() =>
            {
                var unused = new IComponent.Resistor(r);
            }, Throws.TypeOf(typeof(ArgumentException)));
        }
    }
}
