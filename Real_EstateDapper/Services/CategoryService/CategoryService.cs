using Dapper;
using Real_EstateDapper.Context;
using Real_EstateDapper.Dto.CategoryDtos;

namespace Real_EstateDapper.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly Real_EstateDapperContext _context;

        public CategoryService(Real_EstateDapperContext context)
        {
            _context = context;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            // SQL sorgusu, Categories tablosuna yeni bir kategori ekler.
            string query = "insert into Categories (CategoryName) values (@categoryName)";

            // DynamicParameters nesnesi, sorgu parametrelerini tutmak için kullanılır.
            var parameters = new DynamicParameters();

            // Parametre ekleniyor: @categoryName parametresine createCategoryDto.CategoryName değeri atanıyor.
            parameters.Add("@categoryName", createCategoryDto.CategoryName);

            // Veritabanı bağlantısı oluşturuluyor.
            var connection = _context.CreateConnection();

            // SQL sorgusu ve parametreler kullanılarak veritabanına asenkron olarak veri ekleniyor.
            await connection.ExecuteAsync(query, parameters);

        }

        public async Task DeleteCategoryAsync(int id)
        {
            //sql değişken tanımmlama işlemleri @ sembölü ile yapılıyor
            string query = "Delete From Categories Where Id=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);

        }
        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Categories";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            return values.ToList();
        }

        public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(int id)
        {
            string query = "select * from Categories Where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            var x = _context.CreateConnection();
            var values = await x.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
            return values;
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            string query = "Update Categories Set CategoryName=@categoryName Where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", updateCategoryDto.CategoryName);
            parameters.Add("@categoryId", updateCategoryDto.Id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
    }
}
