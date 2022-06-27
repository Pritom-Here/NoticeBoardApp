using NoticeBoardApp.Models;

namespace NoticeBoardApp.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Task<ApplicationUser> FindByNameAsync(string name);
    }
}
