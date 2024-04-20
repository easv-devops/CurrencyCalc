using Serilog;
using Serilog.Core;
using ILogger = Serilog.ILogger;

namespace CurrencyCalc.Pages;

public static class MonitorService
{
    public static ILogger Log => Serilog.Log.Logger;

    static MonitorService()
    {
        Serilog.Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console()
            .CreateLogger();
    }
}