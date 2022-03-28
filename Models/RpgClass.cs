using System.Text.Json.Serialization;

namespace Adam.albadre.omnisharp.Models
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum RpgClass
    {
         Knight,

         Mage,

         Cleric
    }
}