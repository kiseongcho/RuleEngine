﻿using System.Collections.Generic;

namespace RuleEngine.Console
{
    //shoud this be abstract class?
    public abstract class RuleEngine<TInput, TCondition>
    {
        private readonly IConditionEvaluator<TCondition, TInput> _conditionEvaluator;
        public IList<DecisionStep<TCondition, TInput>> DecisionSteps { get; set; }

        protected RuleEngine(IConditionEvaluator<TCondition, TInput> conditionEvaluator)
        {
            _conditionEvaluator = conditionEvaluator;
        }

        //process list of inputs
        //loop thru all inputs and match against list of conditions, then perform n number of actions associated with the condition
        public virtual void Process(IList<TInput> inputs)
        {
            foreach (var input in inputs)
            {
                foreach (var decisionStep in DecisionSteps)
                {
                    if (_conditionEvaluator.Evaluate(decisionStep.DecisionCondition, input))
                    {
                        foreach (var action in decisionStep.ResultActions)
                        {
                            action.Perform(input);
                        }
                    }
                }
            }
        }
    }
}
