using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Campaign : ValueObject
{
    /// <summary>
    /// Generate a new campaign from url
    /// </summary>
    public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;
        
        InvalidCampaignException.ThrowIfNull(source, "Source invalid");
        InvalidCampaignException.ThrowIfNull(medium, "Medium invalid");
        InvalidCampaignException.ThrowIfNull(name, "Name invalid");
    }
    
    public string Source { get; }
    public string Medium { get; }
    public string Name { get; }
    public string? Id { get; set; }
    public string? Term { get; set; }
    public string? Content { get; set; }
}