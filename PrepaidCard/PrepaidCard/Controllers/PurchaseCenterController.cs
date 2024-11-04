using Microsoft.AspNetCore.Mvc;
using PrepaidCard.Entities;
using PrepaidCard.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrepaidCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseCenterController : ControllerBase
    {
        PurchaseCenterService purchaseCenterService = new PurchaseCenterService();
        // GET: api/<PurchaseCenterController>
        [HttpGet]
        public ActionResult Get()
        {
            var purchaseCenters = purchaseCenterService.GetPurchaseCenters();
            if (purchaseCenters == null)
                return NotFound();
            return Ok(purchaseCenters);
        }

        // GET api/<PurchaseCenterController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var purchaseCenter = purchaseCenterService.GetPurchaseCenterByID(id);
            if (purchaseCenter == null)
                return NotFound();
            return Ok(purchaseCenter);
        }

        // POST api/<PurchaseCenterController>
        [HttpPost]
        public ActionResult Post([FromBody] PurchaseCenterEntity value)
        {
            bool isSuccess = purchaseCenterService.PostPurchaseCenter(value);
            if (isSuccess)
                return Ok(true);
            return NotFound("ID exists in the system");

        }

        // PUT api/<PurchaseCenterController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PurchaseCenterEntity value)
        {
            bool isSuccess = purchaseCenterService.PutPurchaseCenter(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

        // DELETE api/<PurchaseCenterController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = purchaseCenterService.DeletePurchaseCenter(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }
    }
}
