using System;
using Microsoft.Extensions.DependencyInjection;
using CalculatorService;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Run();
        }

        public static IHost CreateHostBuilder(string[] args) =>
            Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
            // The DI container
            .ConfigureLogging(l => l.AddConsole())
            .ConfigureServices(s => s
            .AddSingleton<IAdditor, Additor>()
            .AddSingleton<ISubtractor, Subtractor>()
            .AddSingleton<IMultiplier, Multiplier>()
            .AddSingleton<IDivider, Divider>())
            .ConfigureServices(s => s.AddHostedService<ConsoleApp>())
            .Build();


    }

    public class ConsoleApp: IHostedService
    {
        readonly IAdditor mAdditor;
        readonly ISubtractor mSubtractor;
        readonly IMultiplier mMultiplier;
        readonly IDivider mDivider;
        readonly ILogger<ConsoleApp> mLogger;
        readonly IHostApplicationLifetime mLifetime;

        public ConsoleApp(ILogger<ConsoleApp> logger, IHostApplicationLifetime lifetime, IAdditor additor,
            ISubtractor subtractor, IMultiplier multiplier, IDivider divider)
        {
            mAdditor = additor;
            mSubtractor = subtractor;
            mMultiplier = multiplier;
            mDivider = divider;
            mLogger = logger;
            mLifetime = lifetime;
        }

        public void Run()
        {
            mLogger.Log(LogLevel.Information, "Starting app...");
            mLogger.Log(LogLevel.Information, "Doing some calculations...");
            mLogger.Log(LogLevel.Warning, $"The result of adding is {mAdditor.Add(4, 6)}");
            mLogger.Log(LogLevel.Warning, $"The result of dividing is {mDivider.Divide(6, 3)}");
            mLogger.Log(LogLevel.Warning, $"The result of multiplying is {mMultiplier.Multiply(5, 5)}");
            mLogger.Log(LogLevel.Warning, $"The result of subtracting is {mSubtractor.Subtract(6, 8)}");
            mLogger.Log(LogLevel.Information, "All done!");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            mLifetime.ApplicationStarted.Register(OnStarted);
            mLifetime.ApplicationStopping.Register(OnStopping);
            mLifetime.ApplicationStopped.Register(OnStopped);
            return Task.Run(Run);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private void OnStarted()
        {
            mLogger.LogInformation("OnStarted here!");
        }

        private void OnStopping()
        {
            mLogger.LogInformation("OnStopping here!");
        }

        private void OnStopped()
        {
            mLogger.LogInformation("OnStopped here!");
        }
    }
}
