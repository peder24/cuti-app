using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace backend_cuti_app.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;

        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Role { get; set; } = string.Empty;

        public ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();        
    }
}
