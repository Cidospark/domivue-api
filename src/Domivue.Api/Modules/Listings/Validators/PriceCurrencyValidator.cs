using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Listings.Enums;
namespace Domivue.Api.Modules.Listings.Validators;

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