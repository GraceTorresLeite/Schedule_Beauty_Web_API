using System.Text.Json.Serialization;

namespace WebServiceApi.Data.VO
{
    public class UserVO
    {
        [JsonPropertyName("Usuário")]//serialização versão 5 .NET - mudar nome
        public string UserName { get; set; }

        [JsonPropertyName("Senha")] // para ignorar usar [JsonIgnore]
        public string Password { get; set; }
    }
}
