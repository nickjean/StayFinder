using System.Collections.Generic;
namespace StayFinder.Models {
    public class Property {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; }
        public string HostName { get; set; }
        public string HostImageUrl { get; set; }
        public string Category { get; set; }
        public List<string> Amenities { get; set; } = new List<string>();
        public bool IsFavorite { get; set; }
        public int MaxGuests { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
    }
}