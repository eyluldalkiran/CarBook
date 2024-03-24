﻿using System;
namespace CarBook.Domain.Entities
{
	public class CarFeature
	{
		public int CarFeatureID { get; set; }
		public int CarID{ get; set; }
		public Car Car { get; set; }
		public Feature Feature { get; set; }
		public bool Available { get; set; } //bu özellik var mı kontrolü için 
		
	}
}

