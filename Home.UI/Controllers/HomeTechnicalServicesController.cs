using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Home.UI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class HomeTechnicalServicesController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeTechnicalServicesController(IHomeService homeService)
        {
            _homeService = homeService;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllTechnicalServices()
        {
            var response = await _homeService.GetAllTechnicalServicesAynce();
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdTechnicalServices(int id)
        {
            var response = await _homeService.GetByIdTechnicalServicesAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return NotFound(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] TechnicalServices TechnicalServices)
        {
            var response = await _homeService.UpdateTechnicalServicesAynce(TechnicalServices);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHome([FromBody] TechnicalServices TechnicalServices)
        {
            var response = await _homeService.CreateTechnicalServicesAynce(TechnicalServices);

            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHome(int id)
        {
            var response = await _homeService.DeleteTechnicalServicesAynce(id);
            if (response.StatusCode == 200)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
