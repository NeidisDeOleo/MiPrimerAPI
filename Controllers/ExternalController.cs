using Microsoft.AspNetCore.Mvc;
using MiPrimerAPI.Services;

public class ExternalController : ControllerBase
{
    private readonly ExternalApiService _apiService;

    public ExternalController(ExternalApiService apiService)
    {
        _apiService = apiService;
    }

    [HttpGet("users")]
    public async Task<IActionResult> GetUsers()
    {
        var result = await _apiService.GetUsersAsync();
        return Ok(result);
    }
}
