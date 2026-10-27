using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions.Authentication;

namespace YandexContestClient.Authentication;

public abstract class AccessTokenProviderBase : IAccessTokenProvider
{
    public Task<string> GetAuthorizationTokenAsync(Uri uri,
                                                   Dictionary<string, object>? additionalAuthenticationContext = null,
                                                   CancellationToken cancellationToken = default) =>
        AllowedHostsValidator.IsUrlHostValid(uri)
            ? GetTokenAsync(cancellationToken)
            : Task.FromResult(string.Empty);

    protected abstract Task<string> GetTokenAsync(CancellationToken cancellationToken = default);

    public AllowedHostsValidator AllowedHostsValidator { get; } = new(["api.contest.yandex.net"]);
}
