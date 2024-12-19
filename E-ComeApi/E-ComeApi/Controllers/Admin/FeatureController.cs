using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;

namespace E_ComeApi.Controllers.Admin
{
    public class FeatureController : BaseController
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _featureService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok(await _featureService.GetBtIdAsync(id));
        }
    }
}
