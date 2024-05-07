using Aplication.Service;
using Domain.Entitys.Home.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]

    public class HomeBuildController : ControllerBase
    {
        private readonly IHomeService  _homeService;

        public HomeBuildController(IHomeService homeService)
        {
            _homeService = homeService;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllHomeBuild()
        {
            var response = await _homeService.GetAllHomeBuildAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHomeBuild(int id)
        {
            var response = await _homeService.GetByIdHomeBuildAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomeBuild homeBuild)
        {
            var response = await _homeService.UpdateHomeBuildAynce(homeBuild);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] HomeBuild homeBuild)
        {
            var response = await _homeService.CreateHomeBuildAynce(homeBuild);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeService.DeleteHomeBuildAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

    }
}
