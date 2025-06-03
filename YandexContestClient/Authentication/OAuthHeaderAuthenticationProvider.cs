using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace YandexContestClient.Authentication;

internal sealed class OAuthHeaderAuthenticationProvider(IAccessTokenProvider accessTokenProvider) : IAuthenticationProvider
{
    private const string AuthorizationHeaderKey = "Authorization";
    private const string AuthorizationHeaderValuePrefix = "OAuth";

    public async Task AuthenticateRequestAsync(RequestInformation request,
                                               Dictionary<string, object>? additionalAuthenticationContext = null,
                                               CancellationToken cancellationToken = default)
    {
        if (request is null) throw new ArgumentNullException(nameof(request));

        request.Headers.Remove(AuthorizationHeaderKey);

        if (!request.Headers.ContainsKey(AuthorizationHeaderKey))
        {
            var accessToken = await accessTokenProvider.GetAuthorizationTokenAsync(request.URI, additionalAuthenticationContext, cancellationToken);

            if(!string.IsNullOrEmpty(accessToken))
                request.Headers.Add(AuthorizationHeaderKey, $"{AuthorizationHeaderValuePrefix} {accessToken}");
        }
    }
}
