using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeEquipmentController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeEquipmentController(IHomeService homeService)
        {
            _homeService = homeService;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllHomeEquipment()
        {
            var response = await _homeService.GetAllHomeEquipmentAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeEquipment(int id)
        {
            var response = await _homeService.GetByIdHomeEquipmentAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomeEquipment HomeEquipment)
        {
            var response = await _homeService.UpdateHomeEquipmentAynce(HomeEquipment);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] HomeEquipment HomeEquipment)
        {
            var response = await _homeService.CreateHomeEquipmentAynce(HomeEquipment);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeService.DeleteHomeEquipmentAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
