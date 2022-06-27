using Microsoft.EntityFrameworkCore;
using NoticeBoardApp.Data;
using NoticeBoardApp.Models;
using NoticeBoardApp.Repositories.Interfaces;

namespace NoticeBoardApp.Repositories
{
    public class NoticeRepository : INoticeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public NoticeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Notice notice)
        {
            await _dbContext.Notices.AddAsync(notice);
        }

        public async Task<IEnumerable<Notice>> GetAllAsync()
        {
            var noticesInDb = await _dbContext
                                    .Notices
                                    .Include(n => n.Creator)
                                    .Include(n => n.Modifier)
                                    .OrderByDescending(n => n.CreatedOn)
                                    .ToListAsync();
            return noticesInDb;
        }

        public async Task<Notice> GetAsync(string id)
        {
            var noticeInDb = await _dbContext.Notices.Include(n => n.Creator).Include(n => n.Modifier).FirstOrDefaultAsync(n => n.Id == id);
            return noticeInDb;
        }
    }
}
