
public class StravaAuthService{
    private readonly OAuthenticator _oauthenticator;

    public StravaAuthenticationService()
    {
        _oauthenticator = new OAuthenticator(new ClientCredentials { ClientId = "YOUR_CLIENT_ID", ClientSecret = "YOUR_CLIENT_SECRET" });
    }

    public string GetAuthorizationUrl(string redirectUri, string state)
    {
        return _oauthenticator.GetRequestAuthorizationUrl(redirectUri, state, Scope.Read | Scope.ActivityReadAll);
    }

    public async Task<StravaAccessTokenResponse> HandleCallbackAsync(string code)
    {
        return await _oauthenticator.RequestTokenExchangeAsync(code);
    }
    
}