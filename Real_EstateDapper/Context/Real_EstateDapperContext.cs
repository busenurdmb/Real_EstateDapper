using System.Data;
using System.Data.SqlClient;

namespace Real_EstateDapper.Context
{
    public class Real_EstateDapperContext
    {
        // IConfiguration örneği, yapılandırma ayarlarını tutar.
        //GetConnectionString() methoda erişim sağlamaktı.bu method IConfiguration içinden geliyor.
        private readonly IConfiguration _configuration;

        // Veritabanı bağlantı dizesi.
        //appsetting.json da oluşturduğumuzda bağlantı dizisine ona erişim sağlamak için oluşturduğum değişken
        private readonly string _connectionString;

        // Kurucu metot, yapılandırma ayarlarını alır ve bağlantı dizesini ayarlar.
        public Real_EstateDapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("connection");
        }

        // CreateConnection metodu, yeni bir SqlConnection nesnesi oluşturur ve döner.
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
