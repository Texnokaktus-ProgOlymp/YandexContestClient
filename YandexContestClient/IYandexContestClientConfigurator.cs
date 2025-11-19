using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions.Authentication;

namespace YandexContestClient;

public interface IYandexContestClientConfigurator
{
    IServiceCollection Services { get; }
    IYandexContestClientConfigurator AuthenticateWithTokenProvider<TAccessTokenProvider>() where TAccessTokenProvider : class, IAccessTokenProvider;
    IYandexContestClientConfigurator AuthenticateWithTokenProvider<TAccessTokenProvider>(Func<IServiceProvider, TAccessTokenProvider> implementationFactory) where TAccessTokenProvider : class, IAccessTokenProvider;
}
