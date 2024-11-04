using Microsoft.AspNetCore.Mvc;
using PrepaidCard.Entities;
using PrepaidCard.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrepaidCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        // GET: api/<CardController>
        CardService cardService=new CardService();
        [HttpGet]
        public ActionResult Get()
        {
            var cards = cardService.GetCards();
            if (cards == null)
                return NotFound();
            return Ok(cards);
        }

        // GET api/<CardController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var card = cardService.GetCardByID(id);
            if (card == null)
                return NotFound();
            return Ok(card);
        }

        // POST api/<CardController>
        [HttpPost]
        public ActionResult Post([FromBody] CardEntity value)
        {
            bool isSuccess = cardService.PostCard(value);
            if (isSuccess)
                return Ok(true);
            return NotFound("ID exists in the system");
        }

        // PUT api/<CardController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CardEntity value)
        {
            bool isSuccess = cardService.PutCard(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }


        // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = cardService.DeleteCard(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }
    }
}
