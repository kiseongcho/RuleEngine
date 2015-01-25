using System;
using System.Linq.Expressions;
using System.Reflection;
namespace RuleEngine.Console
{
    public class StringConditionEvaluator<TInput> : IConditionEvaluator<string, TInput>
    {
        public bool Evaluate(ICondition<string> condition, TInput input)
        {
            var conditionExpression = condition.ConditionExpression;
            var p = Expression.Parameter(typeof(TInput), typeof(TInput).Name);
            try
            {
                var e = System.Linq.Dynamic.DynamicExpression.ParseLambda(new[] { p }, typeof(object), conditionExpression);
                return ((bool)e.Compile().DynamicInvoke(input));
            }
            catch (Exception ex)
            {
                if (ex is MemberAccessException || ex is ArgumentException || ex is TargetInvocationException)
                {
                    throw new Exception(string.Format("Expression string could not be compiled to return boolean result! {0} - {1}", conditionExpression, ex.Message));
                }
                throw new Exception(string.Format("Expression string could not be parsed correctly! {0} - {1}", conditionExpression, ex.Message));
            }
        }
    }
}