using Aplication.Service;
using Domain.Entitys.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeRentController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeRentController(IHomeService homeService)
        {
            _homeService = homeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllHomesRent()
        {
            var response = await _homeService.GetAllHomeRentAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeRent(int Id)
        {
            var response = await _homeService.GetByIdHomeRentAynce(Id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }
   

        [HttpPut]
        public async Task<IActionResult> UpdateHomeRent([FromBody] HomeRent homeRent)
        {
            var response = await _homeService.UpdateHomeRentAynce(homeRent);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHomeRent([FromBody] HomeRent homeRent)
        {
            var response = await _homeService.CreateHomeRentAynce(homeRent);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHomeRent (int id)
        {
            var response = await _homeService.DeleteHomeRentAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
