using Microsoft.EntityFrameworkCore;
using NoticeBoardApp.Data;
using NoticeBoardApp.Models;

namespace NoticeBoardApp.Repositories.Interfaces
{
    public class NoticeViewerRepository : INoticeViewerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public NoticeViewerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(NoticeViewer noticeViewer)
        {
            await _dbContext.NoticeViewers.AddAsync(noticeViewer);
        }

        public async Task<IEnumerable<NoticeViewer>> GetAllAsync()
        {
            var noticeViewersInDb = await _dbContext.NoticeViewers.Include(nv => nv.User).Include(nv => nv.Notice).ToListAsync();
            return noticeViewersInDb;
        }

        public async Task<NoticeViewer> GetAsync(string userId, string noticeId)
        {
            var noticeViewerInDb = await _dbContext.NoticeViewers
                                                    .Include(nv => nv.User)
                                                    .Include(nv => nv.Notice)
                                                    .FirstOrDefaultAsync(nv => nv.UserId == userId && nv.NoticeId == noticeId);
            return noticeViewerInDb;
        }

        public async Task<IEnumerable<NoticeViewer>> GetNoticeViewedByUserAsync(string userId)
        {
            var noticesInDb = await _dbContext.NoticeViewers
                                                    .Include(nv => nv.Notice)
                                                    .Where(nv => nv.UserId == userId).ToListAsync();
            return noticesInDb;
        }


    }
}
