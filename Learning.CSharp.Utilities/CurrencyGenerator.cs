using System;

namespace Learning.CSharp.Utilities
{
    public class CurrencyGenerator
    {

        #region Variables.
        static readonly Random RandomObject = new Random();
        private readonly double _minimumValue;
        private readonly double _currencyValue;
        #endregion

        public CurrencyGenerator(double minimumValue = 1.0f, double maximumValue = 1000.0f)
        {
            _minimumValue = minimumValue;
            _currencyValue = (maximumValue - _minimumValue);
        }

        #region Methods
        public decimal GenerateAmount()
        {
            var currentValue = RandomObject.NextDouble();
            return (decimal) ((_minimumValue) + (currentValue*_currencyValue));
        }
        #endregion

    }
}