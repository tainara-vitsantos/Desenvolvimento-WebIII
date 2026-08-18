using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Vasos_Inteligentes.Models
{
    public class Planta
    {
       [BsonId]
       [BsonRepresentation(BsonType.ObjectId)]

       public string Id { get; set; }

       public string Nome { get; set; }

       public double UmidadeIdealMin { get; set; }

       public double UmidadeIdealMax { get; set; }

       public double LuminosidadeIdeal { get; set; }
    }
}
