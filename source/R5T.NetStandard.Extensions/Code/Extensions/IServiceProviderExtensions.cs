using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace R5T.NetStandard
{
    public static class IServiceProviderExtensions
    {
        public static IConfiguration GetConfiguration(this IServiceProvider serviceProvider)
        {
            var output = serviceProvider.GetRequiredService<IConfiguration>();
            return output;
        }

        /// <summary>
        /// Directly gets the <typeparamref name="TOptions"/> value from the <see cref="IOptions{TOptions}"/> service.
        /// </summary>
        public static TOptions GetOptions<TOptions>(this IServiceProvider serviceProvider)
            where TOptions : class, new()
        {
            var optionsOptions = serviceProvider.GetRequiredService<IOptions<TOptions>>();
            var options = optionsOptions.Value;
            return options;
        }
    }
}
