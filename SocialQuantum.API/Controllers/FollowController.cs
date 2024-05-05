using Microsoft.AspNetCore.Mvc;
using SocialQuantum.Application.DTOs.Follows;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class FollowController : ControllerBase
	{
		private readonly IFollowService _followerService;

		public FollowController(IFollowService followerService)
		{
			_followerService = followerService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<FollowDTO>>> SearchAllAsync()
		{
			IEnumerable<FollowDTO> follows = await _followerService.GetAllFollowsAsync();
			if(!follows.Any()) return NotFound();

			return Ok(follows);
		}

		[HttpGet("follower/{id:int:minlength(1)}")]
		public async Task<ActionResult<IEnumerable<FollowDTO>>> SearchFollowerByIdAsync(int id)
		{
			IEnumerable<FollowDTO> follows = await _followerService.GetFollowerByIdAsync(id);
			if(!follows.Any()) return NotFound();

			return Ok(follows);
		}

		[HttpGet("following/{id:int:minlength(1)}")]
		public async Task<ActionResult<IEnumerable<FollowDTO>>> SearchFollowingByIdAsync(int id)
		{
			IEnumerable<FollowDTO> follows = await _followerService.GetFollowingByIdAsync(id);
			if (!follows.Any()) return NotFound();

			return Ok(follows);
		}

		[HttpPost]
		public async Task<ActionResult<FollowPersistenceDTO>> CreateAsync(FollowPersistenceDTO follow)
		{
			try
			{
				if (follow == null) return BadRequest("The entity is invalid.");
				await _followerService.CreateFollowAsync(follow);

				return Created();
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
				await _followerService.DeleteFollowAsync(id);

				return NoContent();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
