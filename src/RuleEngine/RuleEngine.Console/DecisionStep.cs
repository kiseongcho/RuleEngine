using System.Collections.Generic;

namespace RuleEngine.Console
{
    public class DecisionStep<TCondition, TInput>
    {
        //Unique Id for this node
        public int Id { get; set; }
        //Has condition that should evaluate to true
        public ICondition<TCondition> DecisionCondition { get; set; } 
        //Should have series of actions to perform once the condition is met
        public IList<ResultAction<TInput>> ResultActions { get; set; }
    }
}
