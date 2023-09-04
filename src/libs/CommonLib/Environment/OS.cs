using CommonLib.Enums;
using CommonLib.Enums;
namespace CommonLib.Environment;

public static class OS
{
    public static PlatformType Platform()
    {
        PlatformType result = PlatformType.Unknown;
        
        if (OperatingSystem.IsLinux()){
            return PlatformType.Linux;
        }

        if (OperatingSystem.IsMacOS()){
            return PlatformType.Mac;
        }

        if (OperatingSystem.IsWindows())
        {
            return PlatformType.Windows;
        }

        if (OperatingSystem.IsFreeBSD())
        {
            return PlatformType.BSD;
        }

        return result;
    }
}