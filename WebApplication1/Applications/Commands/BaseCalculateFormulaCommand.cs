using WebApplication1.Domain;

namespace WebApplication1.Applications.Commands
{
    public class BaseCalculateFormulaCommand
    {
        public BaseCalculateFormulaCommand(Guid id, string name, string description, Options options)
        {
            Id = id;
            Name = name;
            Description = description;
            Options = options;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public Options Options { get; set; }         
    }

    public class Options
    {
        public AcrOptions AcrOptions { get; set; }
        public AclOptions AclOptions { get; set; }
    }

    public class AcrOptions
    {
        public ECalculateFormulaOptions Energy { get; set; }
        public ECalculateFormulaOptions Flag { get; set; }
        public ECalculateFormulaOptions TusdFio { get; set; }
        public ECalculateFormulaOptions ExceedingDemand { get; set; }
        public ECalculateFormulaOptions ChargesTusd { get; set; }
        public ECalculateFormulaOptions ReactiveEnergy { get; set; }
        public ECalculateFormulaOptions ReactiveDemand { get; set; }
        public ECalculateFormulaOptions Generator { get; set; }
    }

    public class AclOptions
    {
        public ECalculateFormulaOptions Energy { get; set; }
        public ECalculateFormulaOptions TusdFio { get; set; }
        public ECalculateFormulaOptions LastDemand { get; set; }
        public ECalculateFormulaOptions ChargesTusd { get; set; }
        public ECalculateFormulaOptions ReactiveEnergy { get; set; }
        public ECalculateFormulaOptions ReactiveDemand { get; set; }
        public ECalculateFormulaOptions FinancialSettlement { get; set; }
        public ECalculateFormulaOptions EER { get; set; }
        public ECalculateFormulaOptions AssociativeContribution { get; set; }
        public ECalculateFormulaOptions CovidCDE { get; set; }
    }
}
