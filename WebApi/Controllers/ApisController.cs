using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;


using WebApi.Models;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("WebApi/[Controller]")]
    public class ApisController : Controller
    {
        private readonly IApiService _apiService;

        public ApisController(IApiService apiService) // Injection 
        {
            _apiService = apiService ?? throw new ArgumentNullException(nameof(apiService)); //validate if null
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Api>), 200)]
        public async Task<IActionResult> ReadAllAsync()
        {
            var allApis = await _apiService.ReadAllAsync();
            return Ok(allApis);
        }
    }

   
}