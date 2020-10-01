using FactCalcWebApp.Models;
using FactCalcWebApp.Services;
using System;
using Xunit;

namespace FactCalcXUnitTest
{
    public class UnitTest1
    {
        public readonly IFactCalcServices _services;
        public UnitTest1(IFactCalcServices services)
        {
            _services = services;
        }
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            var factNumModel = new FactCalcModel();
            factNumModel.InputFactNumber = 10;

            Assert.Throws<InvalidOperationException>(
                () => _services.CalculateFactorial(factNumModel)
                );
        }
    }
}
