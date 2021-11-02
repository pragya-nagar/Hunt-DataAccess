namespace Synergy.DataAccess.Enum
{
    public enum LogicType
    {
        Contains = 1,
        DoesNotContain = 2,
        Equal = 3,
        NotEqual = 4,
        LessThan = 5,
        LessThanOrEqual = 6,
        GreaterThan = 7,
        GreaterThanOrEqual = 8,
        EqualBool = 9,
        NotEqualBool = 10,
    }

    public enum RuleField
    {
        AccountName = 1,
        County = 2,
        GeneralLandUseCode = 3,
        TotalAmountDue = 4,
        TotalAmountDueProperties = 5,
        LTVPercent = 6,
        LTVPercentOfProperties = 7,
        AppraisedValue = 8,
        AppraisedValueOfProperties = 9,
        Over65SurvivingSpouse = 10,
        DisabilityExemption = 11,
        Veteran = 12,
        DoNotContact = 13,
    }
}
