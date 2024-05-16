using Blazored.LocalStorage;
using Newtonsoft.Json;
using Restaurant_site.client.DTO;
using Restaurant_site.client.Services;

namespace BankManagementSystem.Client.Sevices;

public class TokenProvider : ITokenProvider
{
    readonly IServiceProvider _provider;
    readonly ISyncLocalStorageService _localStorage;
    public TokenProvider(IServiceProvider provider, ISyncLocalStorageService localStorage)
    {
        _provider = provider;
        _localStorage = localStorage;
        LoadTokenInfo();
    }

    public bool IsAuthenticated { get; set; }

    bool IsTokenExpired => token == null || token.ExpireTime < DateTimeOffset.Now;

    static TokenInfo token;
    public string GetAccessToken()
    {
        if (IsTokenExpired && token is not null)
            GetNewRefreshToken(token.RefreshToken);

        return token?.AccessToken;
    }

    private IHttpAPIProvider GetHttpAPIProvider() =>
        _provider.GetService<IHttpAPIProvider>();

    public async Task<(bool IsAuthenticated, string message)> LoginAsync(LoginModel loginModel)
    {
        var (isSuccessStatusCode, tokenInfo, message) = await GetHttpAPIProvider().PostAsync<TokenInfo>($"Auth/Token?username={loginModel.Username}&password={loginModel.Password}");
        UpdateTokenInfo(isSuccessStatusCode, tokenInfo);

        Console.WriteLine($"Login successful: {isSuccessStatusCode}");
        Console.WriteLine($"Token Info: {JsonConvert.SerializeObject(tokenInfo)}");

        return (isSuccessStatusCode, message);
    }

    public void Logout()
    {
        UpdateTokenInfo(false);
        Console.WriteLine("User logged out");
    }

    private void UpdateTokenInfo(bool successfullyAuthenticated, TokenInfo tokenInfo = null)
    {
        if (successfullyAuthenticated)
        {
            IsAuthenticated = true;
            token = tokenInfo;

            _localStorage.SetItem(nameof(TokenInfo), tokenInfo);
            Console.WriteLine("Token info updated and saved to local storage");
        }
        else
        {
            IsAuthenticated = false;
            token = null;

            _localStorage.RemoveItem(nameof(TokenInfo));
            Console.WriteLine("Token info cleared from local storage");
        }
    }


    private void LoadTokenInfo()
    {
        if (_localStorage.ContainKey(nameof(TokenInfo)))
        {
            token = _localStorage.GetItem<TokenInfo>(nameof(TokenInfo));
            IsAuthenticated = !IsTokenExpired;
            Console.WriteLine($"Token loaded: {JsonConvert.SerializeObject(token)}");
        }
        else
        {
            Console.WriteLine("No token found in local storage");
        }
    }

    private void GetNewRefreshToken(string refreshToken)
    {
        (bool isSuccessStatusCode, TokenInfo tokenInfo, string message) = GetHttpAPIProvider().PostAsync<TokenInfo>($"Auth/RefreshToken?refreshToken={refreshToken}").GetAwaiter().GetResult();
        UpdateTokenInfo(isSuccessStatusCode, tokenInfo);
    }
}