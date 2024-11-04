using Microsoft.AspNetCore.Mvc;
using PrepaidCard.Entities;
using PrepaidCard.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrepaidCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        StoreService storeService = new StoreService();
        // GET: api/<StoreController>
        [HttpGet]
        public ActionResult Get()
        {
            var stores = storeService.GetStores();
            if (stores == null)
                return NotFound();
            return Ok(stores);
        }

        // GET api/<StoreController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var store = storeService.GetStoreById(id);
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        // POST api/<StoreController>
        [HttpPost]
        public ActionResult Post([FromBody] StoreEntity value)
        {
            bool isSuccess = storeService.PostStore(value);
            if (isSuccess)
                return Ok(true);
            return NotFound("ID exists in the system");

        }

        // PUT api/<StoreController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] StoreEntity value)
        {
            bool isSuccess = storeService.PutStore(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound(); ;
        }

        // DELETE api/<StoreController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = storeService.DeleteStore(id);
            if (isSuccess)
                return Ok(true);
            return NotFound(); ;
        }
    }
}
