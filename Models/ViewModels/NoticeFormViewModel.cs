using System.ComponentModel.DataAnnotations;

namespace NoticeBoardApp.Models.ViewModels
{
    public class NoticeFormViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        [Display(Name = "Subtitle")]
        [StringLength(300, MinimumLength = 0)]
        public string SubTitle { get; set; }

        [Required]
        [StringLength(50000)]
        public string Details { get; set; }
    }
}
