using Corendon.Common.Settings.Data;
using Corendon.ViewModels.Abstract.Announcement;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Corendon.ViewModels.Concrate.Announcement
{
    public class AnnouncementEntityModel : IAnnouncementEntityModel
    {
        [DataType(DataType.Text), MaxLength(50), Required]
        public string? Title { get; set; }

        [DataType(DataType.MultilineText), MaxLength(50), Required]
        public string? Content { get; set; }

        [Required]
        public IFormFile? Picture { get; set; }

        [Required]
        public AnnouncementTypeEnum AnnouncementType { get; set; }
    }
}
