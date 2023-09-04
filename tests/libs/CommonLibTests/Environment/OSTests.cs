namespace CommonLibTests.Environment;

using NUnit.Framework;
using CommonLib.Environment;
using CommonLib.Enums;
using System;

[TestFixture]
public class OSTests
{
    [Test]
    public void TesPlatform()
    {
        PlatformType platformType = OS.Platform();

        if (OperatingSystem.IsLinux()){
            Assert.True(platformType == PlatformType.Linux);
        }

        if (OperatingSystem.IsMacOS()){
            Assert.True(platformType == PlatformType.Mac);
        }

        if (OperatingSystem.IsWindows())
        {
            Assert.True(platformType == PlatformType.Windows);
        }

        if (OperatingSystem.IsFreeBSD())
        {
            Assert.True(platformType == PlatformType.BSD);
        }

        
    }
}