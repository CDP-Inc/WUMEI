using Microsoft.AspNetCore.Mvc;
using WUMEI.Models.V2018;

namespace WUMEI.Controllers.V2018
{
    /// <summary>
    /// The Cardholder/Card Maintenance functional area comprises functions for maintaining WIC Cardholders
    /// and their cards in the WIC EBT System.
    /// WIC Cardholders and cards are required to access WIC EBT benefits associated with an EBA in the WIC EBT System.
    /// </summary>
    [ApiVersion("2018.1-Preview", Deprecated = true)]
    [Route("WUMEISample/{version:apiVersion}/[controller]/[action]")]
    public class CardholderCardController : Controller
    {
        /// <summary>
        /// The Add Cardholder/Card function is a required function that uses a message based system interface to
        /// create a WIC Cardholder and add an associated Card number.
        /// </summary>
        /// <param name="card">
        /// Details of the cardholder to be added.
        /// </param>
        /// <response code="200">Returns the updated message header.</response>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddCardholderCard(
            [FromBody] AddCardholderCard cardholderCard
        )
        {
            return Ok(cardholderCard.MessageHeader);
        }

        /// <summary>
        /// The Add or Update PIN function is an optional function that uses a message based system interface
        /// to associate a PIN with the cardholder of the given card for WIC online EBT PIN verification.
        /// </summary>
        /// <param name="input">
        /// Details of the account and PIN to be added or updated.
        /// </param>
        /// <response code="200">Returns the updated message header.</response>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult AddUpdatePin(
            [FromBody] AddUpdatePin input
        )
        {
            return Ok(input.MessageHeader);
        }

        /// <summary>
        /// The Get Cardholders/Cards function is a required function that uses a message based system interface
        /// to get a list of cardholders and cards.
        /// </summary>
        /// <param name="input">data specifying the cardholder information to return</param>
        /// <returns></returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCardholdersCardsResult), 200)]
        public IActionResult GetCardholdersCards(
            [FromBody] GetCardholdersCards input
        )
        {
            return Ok(new GetCardholdersCardsResult
            {
                MessageHeader = input.MessageHeader,
            });
        }

        /// <summary>
        /// The Update Card/Cardholder function is a required function that uses a message based system interface
        /// to update the status and information on a WIC card or cardholder.
        /// </summary>
        /// <param name="request">
        /// </param>
        /// <response code="200">Returns the updated message header.</response>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MessageHeader), 200)]
        public IActionResult UpdateCardholderCard(
            [FromBody] UpdateCardholderCard request
        )
        {
            return Ok(request.MessageHeader);
        }

        /// <summary>
        /// The Get Card History function is a required function that uses a message based system
        /// interface to retrieve the history of the card, i.e., creation, status changes, updates.
        /// </summary>
        /// <param name="input">Details of the input to be returned.</param>
        /// <returns>
        /// A JSON message echoing the sent message header and message body containing
        /// returned records of card transaction history.
        /// </returns>
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCardHistoryResult), 200)]
        public IActionResult GetCardHistory(
            [FromBody] GetCardHistory input
        )
        {
            return Ok(new GetCardHistoryResult
            {
                MessageHeader = input.MessageHeader,
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
            [FromBody] GenerateHotCardList card
        )
        {
            return Ok(card.MessageHeader);
        }
    }
}