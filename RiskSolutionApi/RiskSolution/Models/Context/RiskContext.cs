using Microsoft.EntityFrameworkCore;

namespace RiskSolution.Models.Context
{
    public class RiskContext : DbContext
    {
        public DbSet<AccessibilityViolations> AccessibilityViolations { get; set; }
        public DbSet<ConfidentialityViolations> ConfidentialityViolations { get; set; }
        public DbSet<IntegrityViolations> IntegrityViolations { get; set; }

        public RiskContext(DbContextOptions<RiskContext> options)
       : base(options)
        {
        }
    }
}
