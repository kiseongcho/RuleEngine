namespace RuleEngine.Common
{
    public interface ICondition<TInput>
    {
        int Id { get; set; }
        TInput ConditionExpression { get; set; }
    }
}
