using System.ComponentModel.DataAnnotations;

namespace GligorCoreProject.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "You have violated the length requirements")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90)]
        public int NumberOfDays { get; set; }
    }
}
