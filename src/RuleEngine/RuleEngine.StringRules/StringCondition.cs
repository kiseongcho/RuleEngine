using System;
using RuleEngine.Common;

namespace RuleEngine.StringRules
{
    public class StringCondition : ICondition<String>
    {
        public int Id { get; set; }
        public string ConditionExpression { get; set; }
    }
}
