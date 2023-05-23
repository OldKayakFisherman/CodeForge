using System;
using CommonLib;
using NUnit.Framework;

namespace CommonLibTests;

[TestFixture]
public class RandomTests
{
    [Test]
    public void TestGenerateRandomNonce()
    {
        Assert.IsTrue(!string.IsNullOrEmpty(RandomUtility.GenerateRandomNonce()));
        Assert.IsTrue(RandomUtility.GenerateRandomNonce().Length > 0);
        Assert.IsTrue(RandomUtility.GenerateRandomNonce().IndexOf("=", StringComparison.Ordinal) == -1);
        Assert.IsTrue(RandomUtility.GenerateRandomNonce().IndexOf("#", StringComparison.Ordinal) == -1);
        Assert.IsTrue(RandomUtility.GenerateRandomNonce().IndexOf("@", StringComparison.Ordinal) == -1);
        Assert.IsTrue(RandomUtility.GenerateRandomNonce().IndexOf("$", StringComparison.Ordinal) == -1);
        
}
    
}