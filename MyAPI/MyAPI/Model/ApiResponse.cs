namespace MyAPI.Model
{
    public class ApiResponse
    {
        public string SlackName { get; set; }
        public string CurrentDay { get; set; }
        public DateTime UtcTime { get; set; }
        public string Track { get; set; }
        public string GitHubFileUrl { get; set; }
        public string GitHubRepoUrl { get; set; }
        public string StatusCode { get; } = "200";
    }
}
