using System;

namespace RuleEngine.Console
{
    public class StingCondition : ICondition<String>
    {
        public int Id { get; set; }
        public string ConditionExpression { get; set; }
    }
}
