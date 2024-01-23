namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {//get: okumak için
        //set: yazmak için
        bool Success { get; }
        string Message { get; }

    }
}
