namespace Estate_Dapper_Project.Dtos.PropertDtos
{
    public class GetByIdPropertyDto
    {
        public int PropertyID { get; set; } 
        public string ProductTitle { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public int BedCount { get; set; }
        public int BathRoom { get; set; }
        public int Garage { get; set; }
        public int BuildYear { get; set; }
        public string VideoEmbend { get; set; }
        public string CoverImage { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public bool IsFeatured { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string LocationName { get; set; }
    }
}
