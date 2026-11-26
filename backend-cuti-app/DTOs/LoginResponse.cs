namespace backend_cuti_app.DTOs
{
    public class LoginResponse
    {
        public string token { get; set; } = string.Empty;

        public string fullName { get; set; } = string.Empty;    
        
        public string role { get; set; } = string.Empty;
    }
}
