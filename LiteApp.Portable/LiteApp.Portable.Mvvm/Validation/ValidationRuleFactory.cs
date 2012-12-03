using System;

namespace LiteApp.Portable.Mvvm.Validation
{
    public static class ValidationRuleFactory
    {
        static IRuleLocator _locator;

        public static void Initialize(IRuleLocator locator)
        {
            if (locator == null)
                throw new ArgumentNullException("locator");
            if (_locator != null)
                throw new NotSupportedException("Rule locator has already been set.");
            _locator = locator;
        }

        public static IValidationRule GetRule(ValidationAttribute attr)
        {
            if (_locator == null)
                throw new NotSupportedException("Rule locator is needed. Call Initialize to provide a locator first.");
            return _locator.FindRule(attr);
        }
    }
}
