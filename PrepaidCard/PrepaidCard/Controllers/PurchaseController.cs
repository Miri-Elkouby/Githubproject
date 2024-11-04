using Microsoft.AspNetCore.Mvc;
using PrepaidCard.Entities;
using PrepaidCard.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrepaidCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        PurchaseService purchaseService = new PurchaseService();

        // GET: api/<BuyingController>
        [HttpGet]
        public ActionResult Get()
        {
            var buying = purchaseService.GetPurchases();
            if (buying == null)
                return NotFound();
            return Ok(buying);
        }

        // GET api/<BuyingController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var buying = purchaseService.GetPurchaseById(id);
            if (buying == null)
                return NotFound();
            return Ok(buying);
        }

        // POST api/<BuyingController>
        [HttpPost]
        public ActionResult Post([FromBody] PurchaseEntity value)
        {
            bool isSuccess = purchaseService.PostPurchase(value);
            if (isSuccess)
                return Ok(true);
            return NotFound("ID exists in the system");

        }

        // PUT api/<BuyingController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PurchaseEntity value)
        {
            bool isSuccess = purchaseService.PutPurchase(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

        // DELETE api/<BuyingController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = purchaseService.DeletePurchase(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();

        }
    }
}
