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
    public class ConfidentialityController : ControllerBase
    {
        SearchService _searchService;
        public ConfidentialityController(SearchService searchService)
        {
            _searchService = searchService;
        }


        [HttpPost("")]
        public List<IViolationBase> GetConfidentialityViolations([FromBody] SearchDTO json)
        {
            return _searchService.SearchConfidentialityViolation(json.Field, json.Value).Cast<IViolationBase>().ToList();
        }
    }
}
