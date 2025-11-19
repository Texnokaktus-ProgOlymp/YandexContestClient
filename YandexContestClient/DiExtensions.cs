using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using YandexContestClient.Authentication;
using YandexContestClient.Client;

namespace YandexContestClient;

public static class DiExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddYandexContestAuthentication<TAccessTokenProvider>() where TAccessTokenProvider : class, IAccessTokenProvider =>
            services.AddScoped<IAuthenticationProvider, OAuthHeaderAuthenticationProvider>()
                    .AddScoped<IAccessTokenProvider, TAccessTokenProvider>();

        public IServiceCollection AddYandexContestAuthentication<TAccessTokenProvider>(Func<IServiceProvider, TAccessTokenProvider> implementationFactory) where TAccessTokenProvider : class, IAccessTokenProvider =>
            services.AddScoped<IAuthenticationProvider, OAuthHeaderAuthenticationProvider>()
                    .AddScoped<IAccessTokenProvider, TAccessTokenProvider>(implementationFactory);

        public IServiceCollection AddYandexContestClient() =>
            services.AddScoped<IRequestAdapter, HttpClientRequestAdapter>()
                    .AddScoped<ContestClient>();

        public IServiceCollection AddYandexContestClient(Func<IServiceProvider, ContestClient> implementationFactory) =>
            services.AddScoped<IRequestAdapter, HttpClientRequestAdapter>()
                    .AddScoped(implementationFactory);
    }
}
