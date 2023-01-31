namespace WebApplication1.Domain
{
    public class CalculateFormula: BaseEntity
    {
        public CalculateFormula(string name, string description, Options options)
        {
            Name = name;
            Description = description;
            Options = options;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public Options Options { get; private set; }   
        
        public void ChangeName(string name)
        {                        
            if()
            
            Name = name.Trim();
        }
    }

    public class Options
    {
        public Options(AcrOptions acrOptions, AclOptions aclOptions)
        {
            AcrOptions = acrOptions;
            AclOptions = aclOptions;
        }

        public AcrOptions AcrOptions { get; private set; }
        public AclOptions AclOptions { get; private set; }
    }

    public class AcrOptions
    {
        public ECalculateFormulaOptions Energy { get; private set; }
        public ECalculateFormulaOptions Flag { get; private set; }
        public ECalculateFormulaOptions TusdFio { get; private set; }
        public ECalculateFormulaOptions ExceedingDemand { get; private set; }
        public ECalculateFormulaOptions ChargesTusd { get; private set; }
        public ECalculateFormulaOptions ReactiveEnergy { get; private set; }
        public ECalculateFormulaOptions ReactiveDemand { get; private set; }
        public ECalculateFormulaOptions Generator { get; private set; }
    }

    public class AclOptions
    {
        public ECalculateFormulaOptions Energy { get; private set; }        
        public ECalculateFormulaOptions TusdFio { get; private set; }
        public ECalculateFormulaOptions LastDemand { get; private set; }
        public ECalculateFormulaOptions ChargesTusd { get; private set; }
        public ECalculateFormulaOptions ReactiveEnergy { get; private set; }
        public ECalculateFormulaOptions ReactiveDemand { get; private set; }
        public ECalculateFormulaOptions FinancialSettlement { get; private set; }
        public ECalculateFormulaOptions EER { get; private set; }
        public ECalculateFormulaOptions AssociativeContribution { get; private set; }
        public ECalculateFormulaOptions CovidCDE { get; private set; }

    }
}
