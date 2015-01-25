namespace RuleEngine.Common
{
    //TODO find a way to remove IInput from this interface
    public interface IConditionEvaluator<TCondition, in TInput>
    {
        bool Evaluate(ICondition<TCondition> condition, TInput input);
    }
}
