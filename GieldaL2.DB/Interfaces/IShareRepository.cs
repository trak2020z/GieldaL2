﻿using GieldaL2.DB.Entities;
using System.Collections.Generic;

namespace GieldaL2.DB.Interfaces
{
    /// <summary>
    /// Interface implemented by ShareRepository class
    /// </summary>
    public interface IShareRepository : IRepository
    {
        // <summary>
        /// Declaration of method that returns specific Share entity
        /// </summary>
        /// <param name="id">Identifier of Share</param>
        /// <returns>Singular Share entity</returns>
        Share GetById(int id);
        /// <summary>
        /// Declaration of method that returns Collection of Share entities
        /// </summary>
        /// <returns>Collection of Share entities</returns>
        ICollection<Share> GetAll();

        /// <summary>
        /// Method that returns Collection of Share entities for the specified user.
        /// </summary>
        /// <returns>Collection of Share entities for the specified user.</returns>
        ICollection<Share> GetByUserId(int userId);

        /// <summary>
        /// Declaration of method for adding Share to database
        /// </summary>
        /// <param name="share">Share entity to add</param>
        void Add(Share share);
        /// <summary>
        /// Declaration of method for modifying Share
        /// </summary>
        /// <param name="share">Share entity to modify</param>
        void Edit(Share share);
        /// <summary>
        /// Declaration of method for removing Share
        /// </summary>
        /// <param name="share">Share entity to remove</param>
        void Remove(Share share);

		/// <summary>
		/// Sets share owner by id. (does not save changes)
		/// </summary>
		/// <param name="share"></param>
		/// <param name="ownerid"></param>
		void SetShareOwnerById(Share share, int ownerid);

		/// <summary>
		/// Sets share stock by id. (does not save changes)
		/// </summary>
		/// <param name="share"></param>
		/// <param name="ownerid"></param>
		void SetShareStockById(Share share, int stockid);
	}
}
