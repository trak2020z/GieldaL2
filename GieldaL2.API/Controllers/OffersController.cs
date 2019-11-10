﻿using System.Collections.Generic;
using GieldaL2.API.ViewModels.Edit;
using GieldaL2.API.ViewModels.View;
using Microsoft.AspNetCore.Mvc;

namespace GieldaL2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class OffersController : ControllerBase
    {
        [HttpGet("sell")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<SellOfferViewModel>> GetSell()
        {
            return null;
        }

        [HttpGet("sell/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<SellOfferViewModel> GetSell(int id)
        {
            return null;
        }

        [HttpPost("sell")]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public ActionResult<StatisticsViewModel> PostSell([FromBody] EditSellOfferViewModel order)
        {
            return null;
        }

        [HttpDelete("sell/{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<StatisticsViewModel> DeleteSell(int id)
        {
            return null;
        }

        [HttpGet("buy")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<BuyOfferViewModel>> GetBuy()
        {
            return null;
        }

        [HttpGet("buy/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<BuyOfferViewModel> GetBuy(int id)
        {
            return null;
        }

        [HttpPost("buy")]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public ActionResult<StatisticsViewModel> PostBuy([FromBody] EditBuyOfferViewModel order)
        {
            return null;
        }

        [HttpDelete("buy/{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<StatisticsViewModel> DeleteBuy(int id)
        {
            return null;
        }
    }
}