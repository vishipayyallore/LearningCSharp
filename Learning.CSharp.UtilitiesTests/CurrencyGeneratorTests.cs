using System;
using Learning.CSharp.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.CSharp.UtilitiesTests
{
    [TestClass]
    public class CurrencyGeneratorTests
    {

        [TestMethod]
        public void WhenACurrencyIsGenerated()
        {
            var currencyGenerator = new CurrencyGenerator();
            Console.WriteLine(currencyGenerator.GenerateAmount());
        }

        [TestMethod]
        public void When10DifferentCurrenciesAreGenerated()
        {
            var currencyGenerator = new CurrencyGenerator();
            for (var iCtr = 0; iCtr < 10; iCtr++)
            {
                Console.WriteLine(currencyGenerator.GenerateAmount());
            }
        }


    }
}
