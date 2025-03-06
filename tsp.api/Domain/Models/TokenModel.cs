namespace tsp.api.Domain.Models
{
    public class TokenModel
    {
        public string AccessToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
