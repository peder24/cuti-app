using System.ComponentModel.DataAnnotations;

namespace backend_cuti_app.DTOs
{
    public class LeaveRequest
    {
        public long id { get; set; }

        public long userId { get; set; }

        public string fullName { get; set; } = string.Empty;

        public string startDate { get; set; } = string.Empty;

        public string endDate { get; set; } = string.Empty;

        [MinLength(10)]
        public string reason { get; set; } = string.Empty;
    }
}
