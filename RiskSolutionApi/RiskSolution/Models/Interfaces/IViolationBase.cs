namespace RiskSolution.Models
{
    public interface IViolationBase
    {
        public int Id { get; set; }
        public string Threat { get; set; }
        public string SourceOfThreat { get; set; }
        public string AttackImplementation { get; set; }
    }
}
