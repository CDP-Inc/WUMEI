﻿using Microsoft.AspNetCore.Mvc;
using WUMEI.Models;

namespace WUMEI.Controllers
{
    /// <summary>
    /// The Cardholder/Card Maintenance functional area comprises functions for maintaining WIC Cardholders 
    /// and their cards in the WIC EBT System. 
    /// WIC Cardholders and cards are required to access WIC EBT benefits associated with an EBA in the WIC EBT System.
    /// </summary>
    [ApiVersion("2018.1-Preview")]
    [Route("WUMEI/{version:apiVersion}/[controller]/[action]")]
    public class CardholderCardController : Controller
    {
        /// <summary>
        /// The Add Cardholder/Card function is a required function that uses a message based system interface to
        /// create a WIC Cardholder and add an associated Card number
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddCardholderCard(
            [FromBody]AddCardholderCard card
        )
        {
            return Ok(card.MessageHeader);
        }

        /// <summary>
        /// The Add or Update PIN function is an optional function that uses a message based system interface
        /// to associate a PIN with the cardholder of the given card for WIC Online EBT PIN verification.
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddUpdatePin(
            [FromBody]AddUpdatePin pin
        )
        {
            return Ok(pin.MessageHeader);
        }

        /// <summary>
        /// The Get Cardholders/Cards function is a required function that uses a message based system interface 
        /// to get a list of cardholders and cards.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCardholdersCardsResult), 200)]
        public IActionResult GetCardholdersCards(
            [FromBody]GetCardholdersCards card
        )
        {
            return Ok(new GetCardholdersCardsResult
            {
                MessageHeader = card.MessageHeader,
            });
        }

        /// <summary>
        /// The Update Card/Cardholder function is a required function that uses a message based system interface 
        /// to update the status and information on a WIC card or cardholder.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult UpdateCardholderCard(
            [FromBody]UpdateCardholderCard card
        )
        {
            return Ok(card.MessageHeader);
        }

        /// <summary>
        /// The Get Card History function is a required function that uses a message based system interface to
        /// retrieve the history of the card, i.e., creation, status changes, updates. 
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCardHistoryResult), 200)]
        public IActionResult GetCardHistory(
            [FromBody]GetCardHistory card
        )
        {
            return Ok(new GetCardHistoryResult
            {
                MessageHeader = card.MessageHeader,
            });
        }

        /// <summary>
        /// The Generate Hot Card List function is an optional function that uses a message based system interface
        /// to initiate the generation of the Hot Card List.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult GenerateHotCardList(
            [FromBody]GenerateHotCardList card
        )
        {
            return Ok(card.MessageHeader);
        }
    }
}