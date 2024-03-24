using System;
namespace CarBook.Domain.Entities
{
	//referanslar için
	public class Testimonial
	{
		public int TestimonialID { get; set; }
		public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImgUrl { get; set; }
        
	}
}

