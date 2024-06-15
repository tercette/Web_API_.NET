using System.Text.Json.Serialization;

namespace Web_API.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria,
        Vendas
    }
}
