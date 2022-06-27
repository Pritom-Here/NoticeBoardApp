using System.ComponentModel.DataAnnotations;

namespace NoticeBoardApp.Models.ViewModels
{
    public class NoticeFormViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Title can have maximum 300 characters")]
        public string Title { get; set; }

        [Display(Name = "Subtitle")]
        [StringLength(300, ErrorMessage = "Subtitle can have maximum 300 characters", MinimumLength = 0)]
        public string SubTitle { get; set; }

        [Required]
        [StringLength(50000, ErrorMessage = "Notice Details must have minimum 100 characters to maximum 50000 characters", MinimumLength = 100)]
        public string Details { get; set; }
    }
}
