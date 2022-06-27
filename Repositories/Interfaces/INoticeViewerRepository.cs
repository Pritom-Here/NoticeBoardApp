using NoticeBoardApp.Models;

namespace NoticeBoardApp.Repositories.Interfaces
{
    public interface INoticeViewerRepository
    {
        Task<IEnumerable<NoticeViewer>> GetAllAsync();
        Task<NoticeViewer> GetAsync(string userId, string noticeId);
        Task<IEnumerable<NoticeViewer>> GetNoticeViewedByUserAsync(string userId);
        Task CreateAsync(NoticeViewer noticeViewer);
    }
}
