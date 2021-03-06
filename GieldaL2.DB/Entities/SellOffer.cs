﻿using System;

namespace GieldaL2.DB.Entities
{
	public class SellOffer
	{
		public int Id { get; set; }

        /// <summary>
        /// Id of the seller
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// Seller which created this offer
        /// </summary>
        public virtual User Seller { get; set; }

        /// <summary>
        /// Id of offers share
        /// </summary>
        public int ShareId { get; set; }
        /// <summary>
        /// Shares that are offered for sale
        /// </summary>
        public virtual Share Share { get; set; }
		/// <summary>
		/// Number of shares offered
		/// </summary>
		public int Amount { get; set; }
		/// <summary>
		/// Price per share
		/// </summary>
		public decimal Price { get; set; }
        /// <summary>
		/// Date of making sell offer
		/// </summary>
		public DateTime Date { get; set; }
	}

}
