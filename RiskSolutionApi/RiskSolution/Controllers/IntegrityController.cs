using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskSolution.Models;
using RiskSolution.Models.Interfaces;
using RiskSolution.Services;
using System.Collections.Generic;

namespace RiskSolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrityController : ControllerBase
    {
        SearchService _searchService;
        public IntegrityController(SearchService searchService)
        {
            _searchService = searchService;
        }


        [HttpPost("")]
        public List<IViolationBase> GetIntegrityViolations([FromBody] SearchDTO json)
        {
            return _searchService.SearchIntegrityViolation(json.Field, json.Value);
        }
    }
}
