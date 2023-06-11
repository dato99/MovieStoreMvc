using MovieStoreMvc.Models.DTO;

namespace MovieStoreMvc.Models.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task logoutAsync();
        Task LogoutAsync();
        Task<Status> RegisterAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        //Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
