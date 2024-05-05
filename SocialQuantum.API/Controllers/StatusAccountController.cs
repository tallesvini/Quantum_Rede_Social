using Microsoft.AspNetCore.Mvc;
using SocialQuantum.Application.DTOs.StatusAccount;
using SocialQuantum.Application.Interfaces;

namespace SocialQuantum.API.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class StatusAccountController : ControllerBase
	{
		private readonly IStatusAccountService _statusAccountService;

		public StatusAccountController(IStatusAccountService statusAccountService)
		{
			_statusAccountService = statusAccountService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<StatusAccountDTO>>> SearchAllAsync()
		{
			IEnumerable<StatusAccountDTO> statusAccount = await _statusAccountService.GetAllStatusAsync();
			if (!statusAccount.Any()) return NotFound();

			return Ok(statusAccount);
		}

		[HttpGet("{id:int:minlength(1)}")]
		public async Task<ActionResult<StatusAccountDTO>> SearchByIdAsync([FromRoute] int id)
		{
			StatusAccountDTO statusAccount = await _statusAccountService.GetStatusByIdAsync(id);
			return Ok(statusAccount);
		}

		[HttpPost]
		public async Task<ActionResult<StatusAccountPersistenceDTO>> CreateAsync(StatusAccountPersistenceDTO statusAccount)
		{
			try
			{
				if (statusAccount == null) return BadRequest("The entity is invalid.");
				await _statusAccountService.CreateStatusAsync(statusAccount);

				return Created();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPut("{id:int:minlength(1)}")]
		public async Task<ActionResult<StatusAccountPersistenceDTO>> UpdateAsync([FromRoute] int id, StatusAccountPersistenceDTO statusAccount)
		{
			try
			{
				if (statusAccount == null) return NotFound("The entity is invalid.");
				await _statusAccountService.UpdateStatusAsync(id, statusAccount);

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
				await _statusAccountService.DeleteStatusAsync(id);

				return NoContent();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
