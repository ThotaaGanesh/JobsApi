namespace JobsApi.Models
{
    public class AuthResultViewModel
    {
        public string? token { get; set; }
        public string? username { get; set; }
        public string? role { get; set; }
        public bool Success { get; set; }
        public List<string>? Errors { get; set; }
    }
}
