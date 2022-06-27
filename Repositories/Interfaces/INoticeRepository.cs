using NoticeBoardApp.Models;

namespace NoticeBoardApp.Repositories.Interfaces
{
    public interface INoticeRepository
    {
        Task<IEnumerable<Notice>> GetAllAsync();
        Task<Notice> GetAsync(string id);
        Task CreateAsync(Notice notice);
    }
}
