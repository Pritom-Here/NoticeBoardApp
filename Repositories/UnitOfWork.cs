using Microsoft.AspNetCore.Identity;
using NoticeBoardApp.Data;
using NoticeBoardApp.Models;
using NoticeBoardApp.Repositories.Interfaces;

namespace NoticeBoardApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public INoticeRepository NoticeRepository { get; private set; }
        public IAccountRepository AccountRepository { get; private set; }
        public INoticeViewerRepository NoticeViewerRepository { get; private set; }


        public UnitOfWork(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            
            NoticeRepository = new NoticeRepository(_dbContext);
            AccountRepository = new AccountRepository(_userManager);
            NoticeViewerRepository = new NoticeViewerRepository(_dbContext);
        }

        public async Task<int> CompleteAsync()
        {
            int rowsAffected = await _dbContext.SaveChangesAsync();
            return rowsAffected;
        }

        public void Dispose()
        {
            _dbContext.DisposeAsync();
        }
    }
}
