using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Http.HttpClientLibrary;
using YandexContestClient.Client;

namespace YandexContestClient;

public static class DiExtensions
{
    extension(IServiceCollection services)
    {
        public IYandexContestClientConfigurator AddYandexContestClient()
        {
            services.AddScoped<IRequestAdapter, HttpClientRequestAdapter>()
                    .AddScoped<ContestClient>();

            return new YandexContestClientConfigurator(services);
        }

        public IYandexContestClientConfigurator AddYandexContestClient(Func<IServiceProvider, ContestClient> implementationFactory)
        {
            services.AddScoped<IRequestAdapter, HttpClientRequestAdapter>()
                    .AddScoped(implementationFactory);

            return new YandexContestClientConfigurator(services);
        }
    }
}
