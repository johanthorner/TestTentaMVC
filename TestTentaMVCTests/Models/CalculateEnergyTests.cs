using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTentaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTentaMVC.Models.Tests
{
    [TestClass()]
    public class CalculateEnergyTests
    {
        [TestMethod()]
        public void CalculateEnergyMethodCalculationIsCorrect()
        {
            CalculateEnergy calcylation = new CalculateEnergy();
           
            var expected = 1;
            var actual =  calcylation.CalculateEnergyMethod("1");
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void CalculateEnergyMethodCorrectInput()
        {
            CalculateEnergy calcylation = new CalculateEnergy();

            var expected = 1;
            var actual = calcylation.CalculateEnergyMethod("1");
            Assert.AreEqual(expected, actual);
        }
    }
}