using Aplication.Service;
using Domain.Entitys.Home;
using Domain.Entitys.Home.SpareParts;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HotelController(IHomeService homeService)
        {
            _homeService = homeService;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllHotel()
        {
            var response = await _homeService.GetAllHotelAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHotel(int id)
        {
            var response = await _homeService.GetByIdHotelAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] Hotel Hotel)
        {
            var response = await _homeService.UpdateHotelAynce(Hotel);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] Hotel Hotel)
        {
            var response = await _homeService.CreateHotelAynce(Hotel);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeService.DeleteHotelAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
