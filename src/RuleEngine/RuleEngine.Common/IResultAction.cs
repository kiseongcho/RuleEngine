namespace RuleEngine.Common
{
    //Can action class can be turned into a delegate
    public interface IResultAction<TInput>
    {
        //Change a property of the input object
        //Do something to the input object
        void Perform(TInput input);
    }
}
