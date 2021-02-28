namespace Core.Utilities.Results
{
    //TEMEL VOİD İÇİN
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
