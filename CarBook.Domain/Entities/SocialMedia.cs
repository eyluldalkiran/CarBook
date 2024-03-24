using System;
namespace CarBook.Domain.Entities
{
	public class SocialMedia
	{
		public int SocialMediaID { get; set; }
		public string Name { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
		public List<CarPricing> CarPricings { get; set; }
        
	}
}

