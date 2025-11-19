using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using YandexContestClient.Authentication;

namespace YandexContestClient;

internal class YandexContestClientConfigurator(IServiceCollection services) : IYandexContestClientConfigurator
{
    public IServiceCollection Services => services;
    public IYandexContestClientConfigurator AuthenticateWithTokenProvider<TAccessTokenProvider>() where TAccessTokenProvider : class, IAccessTokenProvider
    {
        services.AddScoped<IAuthenticationProvider, OAuthHeaderAuthenticationProvider>()
                .AddScoped<IAccessTokenProvider, TAccessTokenProvider>();

        return this;
    }

    public IYandexContestClientConfigurator AuthenticateWithTokenProvider<TAccessTokenProvider>(Func<IServiceProvider, TAccessTokenProvider> implementationFactory) where TAccessTokenProvider : class, IAccessTokenProvider
    {
        services.AddScoped<IAuthenticationProvider, OAuthHeaderAuthenticationProvider>()
                .AddScoped<IAccessTokenProvider, TAccessTokenProvider>(implementationFactory);

        return this;
    }

    public IYandexContestClientConfigurator WithObservability()
    {
        services.AddScoped<ObservabilityOptions>(_ => new());

        return this;
    }
}
