namespace Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        var config = Singleton<Config>.Instance;
        config.AppName = "MyApplication";

        var logger = Singleton<Logger>.Instance;
        logger.LogMessage($"Application Name: {config.AppName}");
    }
}
