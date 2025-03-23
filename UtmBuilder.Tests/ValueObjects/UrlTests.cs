using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "banana";
    private const string ValidUrl = "https://www.google.com";
    
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        var url = new Url(InvalidUrl);
    }
    
    [TestMethod]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
       var url = new Url(ValidUrl);
       Assert.IsTrue(true);
    }
}