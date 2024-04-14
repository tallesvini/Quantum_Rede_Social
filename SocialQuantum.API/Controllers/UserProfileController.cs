using Microsoft.AspNetCore.Mvc;
using SocialQuantum.Application.DTOs;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserProfileController : ControllerBase
	{
		private readonly IUserProfileService _userProfileService;

		public UserProfileController(IUserProfileService userProfileService)
		{
			_userProfileService = userProfileService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<UserProfileDTO>>> GetAsync()
		{
			IEnumerable<UserProfileDTO> userProfile = await _userProfileService.GetAllAsync();
			if (!userProfile.Any()) return NotFound();

			return Ok(userProfile);
		}

		[HttpGet("{id:guid:minlength(1)}")]
		public async Task<ActionResult<UserProfileDTO>> GetByIdAsync([FromRoute] Guid id)
		{
			UserProfileDTO userProfile = await _userProfileService.GetByIdAsync(id);
			return Ok(userProfile);
		}

		[HttpPost]
		public async Task<ActionResult<UserProfilePersistenceDTO>> PostAsync(UserProfilePersistenceDTO userProfile)
		{
			try
			{
				if (userProfile == null) return BadRequest("The entity is invalid.");
				await _userProfileService.AddAsync(userProfile);

				return Created();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPut("{id:guid:minlength(1)}")]
		public async Task<ActionResult<UserProfilePersistenceDTO>> Put([FromRoute] Guid id, UserProfilePersistenceDTO userProfile)
		{
			try
			{
				if (userProfile == null) return NotFound("The entity is invalid.");
				await _userProfileService.UpdateAsync(id, userProfile);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpDelete("{id:guid:minlength(1)}")]
		public async Task<ActionResult> Delete(Guid id)
		{
			try
			{
				if (id == Guid.Empty) return NotFound("The id is invalid.");
				await _userProfileService.DeleteAsync(id);

				return NoContent();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
