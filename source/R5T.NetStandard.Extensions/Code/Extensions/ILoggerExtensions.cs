using System;

using Microsoft.Extensions.Logging;


namespace R5T.NetStandard
{
    public static class ILoggerExtensions
    {
        public static void LogAddingTransientService<TService>(this ILogger log)
        {
            log.LogAddingTransientService(typeof(TService));
        }

        public static void LogAddingTransientService(this ILogger log, Type type)
        {
            log.LogInformation($@"{type} - TRANSIENT. Adding service...");
        }

        public static void LogAddingScopedService<TService>(this ILogger log)
        {
            log.LogAddingScopedService(typeof(TService));
        }

        public static void LogAddingScopedService(this ILogger log, Type type)
        {
            log.LogInformation($@"{type} - SCOPED. Adding service...");
        }

        public static void LogAddingSingletonService<TService>(this ILogger log)
        {
            log.LogAddingSingletonService(typeof(TService));
        }

        public static void LogAddingSingletonService(this ILogger log, Type type)
        {
            log.LogInformation($@"{type} - SINGLETON. Adding service...");
        }

        public static void LogAddingService(this ILogger log, string serviceName)
        {
            log.LogInformation($@"{serviceName.ToUpperInvariant()} - Adding service...");
        }

        public static void LogUse(this ILogger log, string serviceName)
        {
            log.LogInformation($@"{serviceName} - Using service.");
        }
    }
}
