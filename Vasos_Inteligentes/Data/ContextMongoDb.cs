using MongoDB.Driver;
using System.Security.Authentication;

namespace Vasos_Inteligentes.Data
{
    public class ContextMongoDb
    {
        private readonly IMongoDatabase _database;

        public ContextMongoDb(IOptions<MongoSettings> settings)
        {
            var mongoSettings = settings.Value;
            var mongoUrl  = new MongoUrl(mongoSettings.ConnectionString);
            var clientSettings = MongoClientSettings.FromUrl(mongoUrl);
            if(mongoSettings.IsSSL) // IsSSl é camada de segurança que criptografa a comunicação entre o cliente e o servidor MongoDB
            {
                clientSettings.SslSettings = new SslSettings { EnabledSslProtocols = SslProtocols.Tls12 }; 
                // É uma versão do protocolo TLS (Transport Layer Security) que fornece segurança para a comunicação na internet. 
                //Ele é usado para proteger dados transmitidos entre o cliente e o servidor, garantindo confidencialidade, integridade e autenticidade das informações.
            }
            var client = new MongoClient(clientSettings);
            _database = client.GetDatabase(mongoSettings.DatabaseName);
        }
        public IMongoCollection<Planta> Plantas 
        {
           get { return _database.GetCollection<Planta>("Plantas"); }
           
        }
    }
}
