using Real_EstateDapper.Dto.CategoryDtos;

namespace Real_EstateDapper.Models
{
	public class PropertyFilterModel
	{
	
			public int? CategoryId { get; set; }
			public string OfferType { get; set; }
			public string City { get; set; }
        public IEnumerable<ResultCategoryDto> Categories { get; set; } // Kategoriler


    }
}
