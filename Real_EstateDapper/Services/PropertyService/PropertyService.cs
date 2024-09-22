using Dapper;
using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Context;
using Real_EstateDapper.Dto.PropertyDtos;
using Real_EstateDapper.Models;

namespace Real_EstateDapper.Services.PropertyService
{
    public class PropertyService:IPropertyService
    {
        private readonly Real_EstateDapperContext _context;

        public PropertyService(Real_EstateDapperContext context)
        {
            _context = context;
        }

        public async Task CreatePropertyAsync(CreatePropertyDto createPropertyDto)
        {
            const string query = @"
                INSERT INTO Properties (Price, Beds, Baths, SqFt, YearBuilt, PricePerSqFt, Description, CategoryId, CreatedAt,Title,ImageUrl,Adreess,OfferType,ImagePropertyId)
                VALUES (@Price, @Beds, @Baths, @SqFt, @YearBuilt, @PricePerSqFt, @Description, @CategoryId, GETDATE(),@Title,@ImageUrl,@Adreess,@OfferType,@ImagePropertyId)";

            var parameters = new DynamicParameters();
            parameters.Add("@Price", createPropertyDto.Price);
            parameters.Add("@Beds", createPropertyDto.Beds);
            parameters.Add("@Baths", createPropertyDto.Baths);
            parameters.Add("@SqFt", createPropertyDto.SqFt);
            parameters.Add("@YearBuilt", createPropertyDto.YearBuilt);
            parameters.Add("@PricePerSqFt", createPropertyDto.PricePerSqFt);
            parameters.Add("@Description", createPropertyDto.Description);
            parameters.Add("@CategoryId", createPropertyDto.CategoryId);
            parameters.Add("@Title", createPropertyDto.Title);
            parameters.Add("@ImageUrl", createPropertyDto.ImageUrl);
            parameters.Add("@Adreess", createPropertyDto.Adreess);
            parameters.Add("@OfferType", createPropertyDto.OfferType);
            parameters.Add("@ImagePropertyId", createPropertyDto.ImagePropertyId);

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task DeletePropertyAsync(int id)
        {
            const string query = "DELETE FROM Properties WHERE Id = @Id";

            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultPropertyDto>> GetAllPropertyAsync()
        {
            const string query = "SELECT * FROM Properties";

            using var connection = _context.CreateConnection();
            var properties = await connection.QueryAsync<ResultPropertyDto>(query);
            return properties.ToList();
        }

        public async Task<List<ResultPropertyWithCategoryDto>> GetAllPropertyWithCategoryAsync()
        {
            const string query = @"
                SELECT p.Id, p.Price, p.Beds, p.Baths, p.SqFt, p.YearBuilt, p.PricePerSqFt, p.Description, c.CategoryName
                FROM Properties p
                INNER JOIN Categories c ON p.CategoryId = c.Id";

            using var connection = _context.CreateConnection();
            var propertiesWithCategory = await connection.QueryAsync<ResultPropertyWithCategoryDto>(query);
            return propertiesWithCategory.ToList();
        }

        public async Task<List<ResultPropertyWithCategoryDto>> GetAllPropertyWithCategoryrProcedureAsync()
        {
            const string query = "EXEC PropertyList"; // 'PropertyList' adında bir saklı prosedür olduğunu varsayıyoruz

            using var connection = _context.CreateConnection();
            var propertiesWithCategory = await connection.QueryAsync<ResultPropertyWithCategoryDto>(query);
            return propertiesWithCategory.ToList();
        }

        public async Task<GetByIdPropertyDto> GetByIdPropertyAsync(int id)
        {
            const string query = @"
        SELECT p.Id, p.Price, p.Beds, p.Baths, p.SqFt, p.YearBuilt, p.PricePerSqFt, p.Description, 
               p.CategoryId, p.ImagePropertyId, p.CreatedAt, p.ImageUrl, p.Adreess, p.Title, p.OfferType,
               c.CategoryName
        FROM Properties p
        INNER JOIN Categories c ON p.CategoryId = c.Id
        WHERE p.Id = @Id";

            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using var connection = _context.CreateConnection();
            var property = await connection.QueryFirstOrDefaultAsync<GetByIdPropertyDto>(query, parameters);
            return property;
        }


        public async Task<int> GetPropertyCountAsync()
        {
            const string query = "SELECT COUNT(*) FROM Properties";

            using var connection = _context.CreateConnection();
            var propertyCount = await connection.QueryFirstOrDefaultAsync<int>(query);
            return propertyCount;
        }

        public async Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto)
        {
            const string query = @"
                UPDATE Properties
                SET Price = @Price, Beds = @Beds, Baths = @Baths, SqFt = @SqFt, YearBuilt = @YearBuilt, 
                    PricePerSqFt = @PricePerSqFt, Description = @Description, CategoryId = @CategoryId
                WHERE Id = @Id";

            var parameters = new DynamicParameters();
            parameters.Add("@Price", updatePropertyDto.Price);
            parameters.Add("@Beds", updatePropertyDto.Beds);
            parameters.Add("@Baths", updatePropertyDto.Baths);
            parameters.Add("@SqFt", updatePropertyDto.SqFt);
            parameters.Add("@YearBuilt", updatePropertyDto.YearBuilt);
            parameters.Add("@PricePerSqFt", updatePropertyDto.PricePerSqFt);
            parameters.Add("@Description", updatePropertyDto.Description);
            parameters.Add("@CategoryId", updatePropertyDto.CategoryId);
            parameters.Add("@Id", updatePropertyDto.Id);

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

	

		public async Task<List<ResultPropertyDto>> GetFilteredProperties(int? categoryId, string offerType, string city)
        {
            // Başlangıç sorgusu
            var query = "SELECT * FROM Properties WHERE 1=1";

            // Sorgu parametreleri
            var parameters = new DynamicParameters();

            // Kategori filtresi
            if (categoryId.HasValue)
            {
                query += " AND CategoryId = @CategoryId";
                parameters.Add("@CategoryId", categoryId.Value); // categoryId yerine categoryId.Value kullanılır
            }

            // Teklif türü filtresi
            if (!string.IsNullOrEmpty(offerType))
            {
                query += " AND OfferType = @OfferType";
                parameters.Add("@OfferType", offerType);
            }

            // Şehir filtresi
            if (!string.IsNullOrEmpty(city))
            {
                query += " AND Adreess = @City";
                parameters.Add("@City", city);
            }

            // Veritabanı bağlantısını oluştur
            using var connection = _context.CreateConnection();

            // Sorguyu çalıştır ve sonuçları al
            var properties = await connection.QueryAsync<ResultPropertyDto>(query, parameters);

            // Listeye dönüştür ve döndür
            return properties.ToList();
        }


        public async Task<List<ResultPropertyDto>> GetAllPropertyAddressAsync()
        {
            const string query = "SELECT DISTINCT Adreess FROM Properties";

            using var connection = _context.CreateConnection();
            var properties = await connection.QueryAsync<ResultPropertyDto>(query);
            //ResultPropertyAddressDto resultPropertyAddressDto = new ResultPropertyAddressDto();
            //resultPropertyAddressDto.Adreess=properties.
            return properties.ToList();
        }
    }
    }


