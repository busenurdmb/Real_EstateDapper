namespace Real_EstateDapper.Dto.PropertyDtos
{
    public class ResultPropertyDto
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
    }
}
