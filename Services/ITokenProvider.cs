using Restaurant_site.client.DTO;

namespace Restaurant_site.client.Services
{
    public interface ITokenProvider
    {
        bool IsAuthenticated { get; }

        string GetAccessToken();

        Task<(bool IsAuthenticated, string message)> LoginAsync(LoginModel loginModel);

        void Logout();
    }
}
