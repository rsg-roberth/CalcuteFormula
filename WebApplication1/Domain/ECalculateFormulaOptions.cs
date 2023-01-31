using System.ComponentModel;

namespace WebApplication1.Domain
{
    public enum ECalculateFormulaOptions
    {
        [Description("Não incluir")]
        NotInclude = 0,
        [Description("Valor bruto")]
        GossValue = 1,
        [Description("Valor bruto + Pis/Cofins")]
        GossValueWithPisCofins = 2,
        [Description("Valor bruto + ICMS")]
        GossValueWithICMS = 3,
        [Description("Valor bruto + Pis/Cofins + ICMS")]
        GossValueWithPisCofinsICMS = 4
    }
}
