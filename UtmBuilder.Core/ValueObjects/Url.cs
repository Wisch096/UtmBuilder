using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObject
{

    private const string UrlRegexPattern = @"^(https?:\/\/)?([\w\-]+(\.[\w\-]+)+)(:\d+)?(\/[^\s]*)?$";

    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (Website link)</param>
    public Url(string address)
    {
        Address = address;
        if(Regex.IsMatch(Address, UrlRegexPattern))
            throw new ArgumentException("Invalid URL address");
    }
    
    /// <summary>
    /// Address of URL (Website link)
    /// </summary>
    public string Address { get; }
}