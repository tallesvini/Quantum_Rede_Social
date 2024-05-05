using Microsoft.AspNetCore.Mvc;
using SocialQuantum.Application.DTOs;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.API.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class UserProfileController : ControllerBase
	{
		private readonly IUserProfileService _userProfileService;

		public UserProfileController(IUserProfileService userProfileService)
		{
			_userProfileService = userProfileService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<UserProfileDTO>>> SearchAllAsync()
		{
			IEnumerable<UserProfileDTO> userProfile = await _userProfileService.GetAllUsersAsync();
			if (!userProfile.Any()) return NotFound();

			return Ok(userProfile);
		}

		[HttpGet("{id:int:minlength(1)}")]
		public async Task<ActionResult<UserProfileDTO>> SearchByIdAsync([FromRoute] int id)
		{
			UserProfileDTO userProfile = await _userProfileService.GetUserByIdAsync(id);
			return Ok(userProfile);
		}

		[HttpPost]
		public async Task<ActionResult<UserProfilePersistenceDTO>> CreateAsync(UserProfilePersistenceDTO userProfile)
		{
			try
			{
				if (userProfile == null) return BadRequest("The entity is invalid.");
				await _userProfileService.CreateUserAsync(userProfile);

				return Created();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPut("{id:int:minlength(1)}")]
		public async Task<ActionResult<UserProfilePersistenceDTO>> UpdateAsync([FromRoute] int id, UserProfilePersistenceDTO userProfile)
		{
			try
			{
				if (userProfile == null) return NotFound("The entity is invalid.");
				await _userProfileService.UpdateUserAsync(id, userProfile);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpDelete("{id:int:minlength(1)}")]
		public async Task<ActionResult> DeleteAsync(int id)
		{
			try
			{
				if (id == 0) return NotFound("The id is invalid.");
				await _userProfileService.DeleteUserAsync(id);

				return NoContent();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
