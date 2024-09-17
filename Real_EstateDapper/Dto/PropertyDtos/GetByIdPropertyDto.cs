namespace Real_EstateDapper.Dto.PropertyDtos
{
    public class GetByIdPropertyDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public int SqFt { get; set; }
        public int YearBuilt { get; set; }
        public decimal PricePerSqFt { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public int? ImagePropertyId { get; set; }
        public DateTime CreatedAt { get; set; }

        public string ImageUrl { get; set; }
        public string Adreess { get; set; }
        public string Title { get; set; }
        public string OfferType { get; set; }
        public string CategoryName { get; set; }
    }
}
