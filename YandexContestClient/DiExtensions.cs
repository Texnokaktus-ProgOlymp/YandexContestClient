﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using YandexContestClient.Authentication;
using YandexContestClient.Client;

namespace YandexContestClient;

public static class DiExtensions
{
    public static IServiceCollection AddYandexContestAuthentication<TAccessTokenProvider>(this IServiceCollection services) where TAccessTokenProvider : class, IAccessTokenProvider =>
        services.AddScoped<IAuthenticationProvider, OAuthHeaderAuthenticationProvider>()
                .AddScoped<IAccessTokenProvider, TAccessTokenProvider>();

    public static IServiceCollection AddYandexContestAuthentication<TAccessTokenProvider>(this IServiceCollection services, Func<IServiceProvider, TAccessTokenProvider> implementationFactory) where TAccessTokenProvider : class, IAccessTokenProvider =>
        services.AddScoped<IAuthenticationProvider, OAuthHeaderAuthenticationProvider>()
                .AddScoped<IAccessTokenProvider, TAccessTokenProvider>(implementationFactory);

    public static IServiceCollection AddYandexContestClient(this IServiceCollection services) =>
        services.AddScoped<IRequestAdapter, HttpClientRequestAdapter>()
                .AddScoped<ContestClient>();

    public static IServiceCollection AddYandexContestClient(this IServiceCollection services, Func<IServiceProvider, ContestClient> implementationFactory) =>
        services.AddScoped<IRequestAdapter, HttpClientRequestAdapter>()
                .AddScoped(implementationFactory);
}
