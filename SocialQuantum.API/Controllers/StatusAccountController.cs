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
		public async Task<ActionResult<IEnumerable<StatusAccountDTO>>> GetAsync()
		{
			IEnumerable<StatusAccountDTO> statusAccount = await _statusAccountService.GetAllAsync();
			if (!statusAccount.Any()) return NotFound();

			return Ok(statusAccount);
		}

		[HttpGet("{id:int:minlength(1)}")]
		public async Task<ActionResult<StatusAccountDTO>> GetByIdAsync([FromRoute] int id)
		{
			StatusAccountDTO statusAccount = await _statusAccountService.GetByIdAsync(id);
			return Ok(statusAccount);
		}

		[HttpPost]
		public async Task<ActionResult<StatusAccountPersistenceDTO>> PostStatusAccount(StatusAccountPersistenceDTO statusAccount)
		{
			try
			{
				if (statusAccount == null) return BadRequest("The entity is invalid.");
				await _statusAccountService.AddAsync(statusAccount);

				return Created();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPut("{id:int:minlength(1)}")]
		public async Task<ActionResult<StatusAccountPersistenceDTO>> Put([FromRoute] int id, StatusAccountPersistenceDTO statusAccount)
		{
			try
			{
				if (statusAccount == null) return NotFound("The entity is invalid.");
				await _statusAccountService.UpdateAsync(id, statusAccount);

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpDelete("{id:int:minlength(1)}")]
		public async Task<ActionResult> Delete(int id)
		{
			try
			{
				if (id == 0) return NotFound("The id is invalid.");
				await _statusAccountService.DeleteAsync(id);

				return NoContent();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
