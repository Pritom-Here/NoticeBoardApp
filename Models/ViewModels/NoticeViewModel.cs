using System.ComponentModel.DataAnnotations;

namespace NoticeBoardApp.Models.ViewModels
{
    public class NoticeViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Details { get; set; }
        public int TotalViews { get; set; }
        public ApplicationUser Creator { get; set; }
        public DateTime CreatedOn { get; set; }
        public ApplicationUser Modifier { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
