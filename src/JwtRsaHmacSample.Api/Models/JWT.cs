namespace JwtRsaHmacSample.Api.Models
{
    public class JWT
    {
        public string Token { get; set; }
        public long Expires { get; set; }          
    }
}