using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoeApi.Repositories;

namespace ShoeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private readonly IShoeRepository _shoeRepository;

        public ShoesController(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        //https://localhost:5001/api/Shoes
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_shoeRepository.GetShoes());
        }

        https://localhost:5001/api/Shoes/3
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var shoeDeleted = _shoeRepository.DeleteShoe(id);

            return shoeDeleted ? NoContent() : NotFound();
        }
    }
}
