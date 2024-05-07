using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeRepairController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeRepairController(IHomeService homeService)
        {
            _homeService = homeService;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllHomeRepair()
        {
            var response = await _homeService.GetAllHomeRepairAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeRepair(int id)
        {
            var response = await _homeService.GetByIdHomeRepairAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomeRepair HomeRepair)
        {
            var response = await _homeService.UpdateHomeRepairAynce(HomeRepair);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] HomeRepair HomeRepair)
        {
            var response = await _homeService.CreateHomeRepairAynce(HomeRepair);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeService.DeleteHomeRepairAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


    }
}
