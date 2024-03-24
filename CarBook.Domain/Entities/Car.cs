using System;
namespace CarBook.Domain.Entities
{
	public class Car
	{
		public int CarID { get; set; }
		public int BrandID { get; set; }
		public Brand Brand { get; set; }
		public string Model { get; set; }
		public string CoverImageUrl { get; set; }
		public int Km { get; set; }
		public int Transmission { get; set; } //Vites Türü
		public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; } //yakıt türü
        public string BigImgUrl { get; set; }
		public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }
        
	}
}

