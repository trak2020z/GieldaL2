﻿using System;

namespace GieldaL2.API.ViewModels.View
{
    public class SellOfferViewModel
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int ShareId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
		public DateTime Date { get; set; }
	}
}