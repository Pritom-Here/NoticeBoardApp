using Microsoft.AspNetCore.Identity;

namespace NoticeBoardApp.Models
{
    public class ApplicationUser: IdentityUser
    {
        public IEnumerable<NoticeViewer> NoticeViewers { get; set; }
    }
}
