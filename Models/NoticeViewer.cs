using System.ComponentModel.DataAnnotations.Schema;

namespace NoticeBoardApp.Models
{
    public class NoticeViewer
    {
        public string NoticeId { get; set; }

        [ForeignKey("NoticeId")]
        public Notice Notice { get; set; }
        
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
