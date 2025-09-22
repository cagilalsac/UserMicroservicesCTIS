namespace CORE.APP.Models
{
    public class CommandResponse : Response // CommandResponse cr = new CommandResponse(); cr.IsSuccessful = true; cr.Message = "Success";
        // cr = new CommandResponse(true, "Success");
    {
        public bool IsSuccessful { get; }
        public string Message { get; }

        public CommandResponse(bool isSuccessful, string message, int id = 0) : base(id)
        {
            IsSuccessful = isSuccessful;
            Message = message;
        }
    }
}
