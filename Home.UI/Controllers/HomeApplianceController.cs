using Aplication.Service;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeApplianceController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeApplianceController(IHomeService homeService)
        {
            _homeService = homeService;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllHomeAppliance()
        {
            var response = await _homeService.GetAllHomeApplianceAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeAppliance(int id)
        {
            var response = await _homeService.GetByIdHomeApplianceAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomeAppliance HomeAppliance)
        {
            var response = await _homeService.UpdateHomeApplianceAynce(HomeAppliance);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] HomeAppliance HomeAppliance)
        {
            var response = await _homeService.CreateHomeApplianceAynce(HomeAppliance);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeService.DeleteHomeApplianceAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
