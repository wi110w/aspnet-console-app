using System;
using Microsoft.Extensions.DependencyInjection;
using CalculatorService;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

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
            .AddSingleton<ICalculator, Additor>()
            .AddSingleton<ICalculator, Subtractor>()
            .AddSingleton<ICalculator, Multiplier>()
            .AddSingleton<ICalculator, Divider>())
            .ConfigureServices(s => s.AddHostedService<ConsoleApp>())
            .Build();


    }

    public class ConsoleApp: IHostedService
    {
        readonly IEnumerable<ICalculator> mCalculator;
        readonly ILogger<ConsoleApp> mLogger;
        readonly IHostApplicationLifetime mLifetime;

        public ConsoleApp(ILogger<ConsoleApp> logger, IHostApplicationLifetime lifetime, IEnumerable<ICalculator> calculator)
        {
            mCalculator = calculator.OrderBy(operation => operation.OperationOrder);
            mLogger = logger;
            mLifetime = lifetime;
        }

        public void Run()
        {
            mLogger.Log(LogLevel.Information, "Starting app...");
            mLogger.Log(LogLevel.Information, "Doing some calculations...");
            mLogger.Log(LogLevel.Warning, "The result of integer calculations:");
            foreach (var operation in mCalculator)
            {
                Console.WriteLine($"{operation.OperationName} = {operation.Calculate(5, 5)}");
            }
            mLogger.Log(LogLevel.Warning, "The result of double calculations:");
            foreach (var operation in mCalculator)
            {
                Console.WriteLine($"{operation.OperationName} = {operation.Calculate(6.7, 3.4)}");
            }
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
