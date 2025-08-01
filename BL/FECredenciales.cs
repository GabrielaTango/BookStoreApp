
namespace BL
{
    public class FECredenciales
    {
        public string Token { get; set; }
        public string Sign { get; set; }
        public string Cuit { get; set; }
        public DateTime ExpirationTime { get; internal set; }
    }
}