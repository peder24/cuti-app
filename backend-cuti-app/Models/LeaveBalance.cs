using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_cuti_app.Models
{
    public class LeaveBalance
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }
        public User? User { get; set; }

        public int Remainingdays { get; set; }
    }
}
