using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        var url = new Url("banana");
    }
    
    [TestMethod]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
       var url = new Url("https://www.google.com");
       Assert.IsTrue(true);
    }
}