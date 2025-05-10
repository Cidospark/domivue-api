using System.ComponentModel.DataAnnotations;
namespace Domivue.Core.Domains.customAttributesValidators;

public class PriceCurrencyValidator : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        PriceCurrency priceCurrencyType;
        string currency = value?.ToString()?.ToUpper() ?? string.Empty;
        if (PriceCurrency.TryParse(currency, out priceCurrencyType))
        {
            return true;
        }
        return false;
    }
}