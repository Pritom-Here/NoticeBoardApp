using Microsoft.AspNetCore.Identity;
using NoticeBoardApp.Models;
using NoticeBoardApp.Repositories.Interfaces;

namespace NoticeBoardApp.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUser> FindByNameAsync(string name)
        {
            return await _userManager.FindByNameAsync(name);
        }
    }
}
