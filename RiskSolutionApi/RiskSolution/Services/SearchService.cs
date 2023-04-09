using Microsoft.EntityFrameworkCore;
using RiskSolution.Models;
using RiskSolution.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RiskSolution.Services
{
    public class SearchService
    {
        RiskContext _context { get; set; }
        public SearchService(RiskContext context) => _context = context;

        public List<IViolationBase> SearchIntegrityViolation(string field, string value)
        {
            if (field == null)
            {
                return _context.IntegrityViolations.
                    FromSqlRaw($"SELECT * FROM dbo.IntegrityViolations WHERE Threat like '%{value}%' OR SourceOfThreat like '%{value}%' OR AttackImplementation like '%{value}%'")
                    .AsNoTracking()
                    .Cast<IViolationBase>()
                    .ToList();
            }

            return _context.IntegrityViolations.
                FromSqlRaw($"SELECT * FROM dbo.IntegrityViolations WHERE {field} like '%{value}%'")
                .AsNoTracking()
                .Cast<IViolationBase>()
                .ToList();
        }

        public List<ConfidentialityViolations> SearchConfidentialityViolation(string field, string value)
        {
            if (field == null)
            {
                return _context.ConfidentialityViolations.
                    FromSqlRaw($"SELECT * FROM dbo.ConfidentialityViolations WHERE Threat like '%{value}%' OR SourceOfThreat like '%{value}%' OR AttackImplementation like '%{value}%'")
                    .AsNoTracking()
                    .ToList();
            }
            return _context.ConfidentialityViolations.
                FromSqlRaw($"SELECT * FROM dbo.ConfidentialityViolations WHERE {field} like '%{value}%'")
                .AsNoTracking()
                .ToList();
        }

        public List<IViolationBase> SearchAccessibilityViolation(string field, string value)
        {

            if (field == null)
            {
                return _context.AccessibilityViolations.
                    FromSqlRaw($"SELECT * FROM dbo.AccessibilityViolations WHERE Threat like '%{value}%' OR SourceOfThreat like '%{value}%' OR AttackImplementation like '%{value}%'")
                    .AsNoTracking()
                    .Cast<IViolationBase>()
                    .ToList();
            }

            return _context.AccessibilityViolations.
                FromSqlRaw($"SELECT * FROM dbo.AccessibilityViolations WHERE {field} like '%{value}%'")
                .AsNoTracking()
                .Cast<IViolationBase>()
                .ToList();
        }


    }
}
