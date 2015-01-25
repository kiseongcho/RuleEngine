using System.Collections.Generic;

namespace RuleEngine.Common
{
    public interface IDecisionStep<TCondition, TInput>
    {
        //Unique Id for this node
        int Id { get; set; }
        //Has condition that should evaluate to true
        ICondition<TCondition> DecisionCondition { get; set; } 
        //Should have series of actions to perform once the condition is met
        IList<IResultAction<TInput>> ResultActions { get; set; }
    }
}
