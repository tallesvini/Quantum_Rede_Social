using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialQuantum.Application.DTOs.Visibility;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class VisibilityController : ControllerBase
	{
		private readonly IVisibilityService _visibilityService;

		public VisibilityController(IVisibilityService visibilityService)
		{
			_visibilityService = visibilityService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<VisibilityDTO>>> GetAsync()
		{
			IEnumerable<VisibilityDTO> visibilityDto = await _visibilityService.GetVisibilityAsync();
			if (!visibilityDto.Any()) NotFound();

			return Ok(visibilityDto);
		}

		[HttpGet("{id:int:minlength(1)}")]
		public async Task<ActionResult<VisibilityDTO>> GetByIdAsync(int id)
		{
			VisibilityDTO visibilityDto = await _visibilityService.GetVisibilityByIdAsync(id);
			if (visibilityDto == null) NotFound();

			return Ok(visibilityDto);
		}
	}
}
