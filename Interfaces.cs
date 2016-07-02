namespace ConsoleApplication
{
#region struts
    public struct record
    {
        public string input;
        public string[] responses;
    }
#endregion

#region Interfaces
    public interface IBot
    {
        string GetResponse(string input);

    }

    public interface IResponseWriter{
        void OutputResponse(string response);
    }

    public interface IInputReader{
        string ReadInput();

    }

#endregion
}