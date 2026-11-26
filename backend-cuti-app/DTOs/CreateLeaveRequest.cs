using System.ComponentModel.DataAnnotations;

namespace backend_cuti_app.DTOs
{
    public class CreateLeaveRequest
    {
        public string startDate { get; set; } = string.Empty;

        public string endDate { get; set; } = string.Empty;

        [MinLength(10)]
        public string reason { get; set; } = string.Empty;
    }
}
