using System.ComponentModel.DataAnnotations;

namespace NoticeBoardApp.Models
{
    public class Notice: BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(300)]
        public string SubTitle { get; set; }

        [Required]
        [StringLength(50000)]
        public string Details { get; set; }

        public int TotalViews { get; set; }

        public IEnumerable<NoticeViewer> NoticeViewers { get; set; }
    }
}
