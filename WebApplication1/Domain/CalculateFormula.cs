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
            if(name == Name)
            {
                return;
            }

            Name = name.Trim();
        }

        public void ChangeValues(CalculateFormula newCalculateFormulaValues)
        {
            if (this.Name != newCalculateFormulaValues.Name)
            {
                this.Name = newCalculateFormulaValues.Name;
            }
            if (this.Description != newCalculateFormulaValues.Description)
            {
                this.Description = newCalculateFormulaValues.Description;
            }

            this.Options.AcrOptions.ChangeValues(newCalculateFormulaValues.Options.AcrOptions);
            this.Options.AclOptions.ChangeValues(newCalculateFormulaValues.Options.AclOptions);
        }               
    }

    public class Options
    {
        public Options(AcrOptions acrOptions, AclOptions aclOptions)
        {
            AcrOptions = acrOptions;
            AclOptions = aclOptions;
        }

        public AcrOptions AcrOptions { get; set; }
        public AclOptions AclOptions { get; set; }
    }

    public class AcrOptions
    {
        public AcrOptions(ECalculateFormulaOptions energy,
            ECalculateFormulaOptions flag,
            ECalculateFormulaOptions tusdFio,
            ECalculateFormulaOptions exceedingDemand,
            ECalculateFormulaOptions chargesTusd,
            ECalculateFormulaOptions reactiveEnergy,
            ECalculateFormulaOptions reactiveDemand,
            ECalculateFormulaOptions generator)
        {
            Energy = energy;
            Flag = flag;
            TusdFio = tusdFio;
            ExceedingDemand = exceedingDemand;
            ChargesTusd = chargesTusd;
            ReactiveEnergy = reactiveEnergy;
            ReactiveDemand = reactiveDemand;
            Generator = generator;
        }

        public ECalculateFormulaOptions Energy { get; private set; }
        public ECalculateFormulaOptions Flag { get; private set; }
        public ECalculateFormulaOptions TusdFio { get; private set; }
        public ECalculateFormulaOptions ExceedingDemand { get; private set; }
        public ECalculateFormulaOptions ChargesTusd { get; private set; }
        public ECalculateFormulaOptions ReactiveEnergy { get; private set; }
        public ECalculateFormulaOptions ReactiveDemand { get; private set; }
        public ECalculateFormulaOptions Generator { get; private set; }

        public void ChangeValues(AcrOptions newOptionValues)
        {
            if (this.Energy != newOptionValues.Energy)
            {
                this.Energy = newOptionValues.Energy;
            }
            if (this.Flag != newOptionValues.Flag)
            {
                this.Flag = newOptionValues.Flag;
            }
            if (this.TusdFio != newOptionValues.TusdFio)
            {
                this.TusdFio = newOptionValues.TusdFio;
            }
            if (this.ExceedingDemand != newOptionValues.ExceedingDemand)
            {
                this.ExceedingDemand = newOptionValues.ExceedingDemand;
            }
            if (this.ChargesTusd != newOptionValues.ChargesTusd)
            {
                this.ChargesTusd = newOptionValues.ChargesTusd;
            }
            if (this.ReactiveEnergy != newOptionValues.ReactiveEnergy)
            {
                this.ReactiveEnergy = newOptionValues.ReactiveEnergy;
            }
            if (this.ReactiveDemand != newOptionValues.ReactiveDemand)
            {
                this.ReactiveDemand = newOptionValues.ReactiveDemand;
            }
            if (this.Generator != newOptionValues.Generator)
            {
                this.Generator = newOptionValues.Generator;
            }
        }
    }

    public class AclOptions
    {
        public AclOptions(ECalculateFormulaOptions energy, 
            ECalculateFormulaOptions tusdFio, 
            ECalculateFormulaOptions lastDemand, 
            ECalculateFormulaOptions chargesTusd, 
            ECalculateFormulaOptions reactiveEnergy,
            ECalculateFormulaOptions reactiveDemand, 
            ECalculateFormulaOptions financialSettlement, 
            ECalculateFormulaOptions eer, 
            ECalculateFormulaOptions associativeContribution, 
            ECalculateFormulaOptions covidCDE)
        {
            Energy = energy;
            TusdFio = tusdFio;
            LastDemand = lastDemand;
            ChargesTusd = chargesTusd;
            ReactiveEnergy = reactiveEnergy;
            ReactiveDemand = reactiveDemand;
            FinancialSettlement = financialSettlement;
            EER = eer;
            AssociativeContribution = associativeContribution;
            CovidCDE = covidCDE;
        }

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

        public void ChangeValues(AclOptions newOptionValues)
        {
            if (this.Energy != newOptionValues.Energy)
            {
                this.Energy = newOptionValues.Energy;
            }
            if (this.TusdFio != newOptionValues.TusdFio)
            {
                this.TusdFio = newOptionValues.TusdFio;
            }
            if (this.LastDemand != newOptionValues.LastDemand)
            {
                this.LastDemand = newOptionValues.LastDemand;
            }
            if (this.ChargesTusd != newOptionValues.ChargesTusd)
            {
                this.ChargesTusd = newOptionValues.ChargesTusd;
            }
            if (this.ReactiveEnergy != newOptionValues.ReactiveEnergy)
            {
                this.ReactiveEnergy = newOptionValues.ReactiveEnergy;
            }
            if (this.ReactiveDemand != newOptionValues.ReactiveDemand)
            {
                this.ReactiveDemand = newOptionValues.ReactiveDemand;
            }
            if (this.FinancialSettlement != newOptionValues.FinancialSettlement)
            {
                this.FinancialSettlement = newOptionValues.FinancialSettlement;
            }
            if (this.EER != newOptionValues.EER)
            {
                this.EER = newOptionValues.EER;
            }
            if (this.AssociativeContribution != newOptionValues.AssociativeContribution)
            {
                this.AssociativeContribution = newOptionValues.AssociativeContribution;
            }
            if (this.CovidCDE != newOptionValues.CovidCDE)
            {
                this.CovidCDE = newOptionValues.CovidCDE;
            }
        }
    }
}
