using Aplication.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Entitys.Home.BaseEntitys;
using Domain.Entitys.Home;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly  IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }




        [HttpGet]
        public async Task<IActionResult> GetAllHomes()
        {
            var response = await _homeService.GetAllHomeAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdHome(int id)
        {
            var response = await _homeService.GetByIdHomeAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }
    
        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] Domain.Entitys.Home.Home home)
        {
            var response = await _homeService.UpdateHomeAynce(home);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public  async Task<IActionResult> CreateHome([FromBody] Domain.Entitys.Home.Home home)
        {
            var response = await _homeService.CreateHomeAynce(home);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeService.DeleteHomeAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
       
    }
}
