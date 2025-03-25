﻿using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UtmTests
{
    private const string Result = "https://balta.io/" +
                                  "?utm_source=src" +
                                  "&utm_medium=med" +
                                  "&utm_campaign=nme" +
                                  "&utm_id=id" +
                                  "&utm_term=ter" +
                                  "&utm_content=ctn";

    private readonly Url _url = new("https://balta.io/");

    private readonly Campaign _campaign = new(
        "src",
        "med",
        "nme",
        "id",
        "ter",
        "ctn");

    [TestMethod]
    public void ShouldReturnUrlFromUtm()
    {
        var utm = new Utm(_url, _campaign);
        
        Assert.AreEqual(Result, utm.ToString());
        Assert.AreEqual(Result, (string)utm);
    }
    
}