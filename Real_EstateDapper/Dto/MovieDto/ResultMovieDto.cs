namespace Real_EstateDapper.Dto.MovieDto
{
	public class ResultMovieDto
	{
		public string MovieUrl { get; set; }  
		public string Title { get; set; }     
		public string Poster { get; set; }    
		public float Release_Year { get; set; }  
		public float Length_In_Min { get; set; }  
		public float IMDB_Rating { get; set; }  
		public float Rating_Count { get; set; }     
		public string Plot { get; set; }         
		public string Directors { get; set; }    
		public string Writers { get; set; }      
		public string Stars { get; set; }        
		public string Genres { get; set; }      
		public int Id { get; set; }              
	}
}
