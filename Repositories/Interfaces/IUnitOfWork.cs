namespace NoticeBoardApp.Repositories.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        public INoticeRepository NoticeRepository { get; }
        public IAccountRepository AccountRepository { get; }
        public INoticeViewerRepository NoticeViewerRepository { get; }

        Task<int> CompleteAsync();
    }
}
