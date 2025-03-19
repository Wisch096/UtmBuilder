using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions;

public partial class InvalidUrlException : Exception
{
    private const string DefaultErrorMessage = "Invalid URL";
    private const string UrlRegexPattern = @"^(https?:\/\/)?([\w\-]+(\.[\w\-]+)+)(:\d+)?(\/[^\s]*)?$";

    public InvalidUrlException(string message = DefaultErrorMessage) : base(message) { }

    public static void ThrowIfInvalidUrl(string address, string message = DefaultErrorMessage)
    {
        if(string.IsNullOrWhiteSpace(address))
            throw new InvalidUrlException(message);
        
        if(!UrlRegex().IsMatch(address))
            throw new InvalidUrlException("Invalid URL address");
    }

    [GeneratedRegex(UrlRegexPattern)]
    private static partial Regex UrlRegex();
}