
namespace LiteApp.Portable.Mvvm.Validation
{
    [RuleMapping(typeof(RequiredFieldRule))]
    public class RequiredFieldAttribute : ValidationAttribute
    {
        public override string DefaultErrorMessage
        {
            get
            {
                if (DisallowWhitespace)
                    return "This field is required and cannot only contain spaces.";
                return "This field is required";
            }
        }

        public bool DisallowWhitespace { get; set; }
    }
}
