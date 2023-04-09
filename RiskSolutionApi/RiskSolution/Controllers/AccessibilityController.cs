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
    public class AccessibilityController : ControllerBase
    {
        SearchService _searchService;
        public AccessibilityController(SearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost("")]
        public List<IViolationBase> GetAccessibilityViolations([FromBody] SearchDTO json)
        {
            return _searchService.SearchAccessibilityViolation(json.Field, json.Value);
        }
    }
}
