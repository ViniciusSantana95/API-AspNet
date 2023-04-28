using System.Text.Json.Serialization;

namespace UFMG.Apresentacao.Entities
{
    public sealed class Produto
    {
        public Guid Id { get; private set; }
        [JsonPropertyName("codigoBarra")]
        public string CodigoBarra { get;  set; }
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }

        public Produto()
        {
            Id = Guid.NewGuid();
        }

    }
}
