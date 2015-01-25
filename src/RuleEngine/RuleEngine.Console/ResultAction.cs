namespace RuleEngine.Console
{
    //Can action class can be turned into a delegate
    public abstract class ResultAction<TInput>
    {
        //Change a property of the input object
        //Do something to the input object
        public abstract void Perform(TInput input);
    }
}
