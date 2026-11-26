using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_cuti_app.Models
{
    public class LeaveRequest
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }
        public User? User { get; set; }

        public string StartDate { get; set; } = string.Empty;

        public string EndDate { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Reason { get; set; } = string.Empty;

        [MaxLength(20)]
        public LeaveRequestStatus Status { get; set; } = LeaveRequestStatus.Pending;
    }
}
