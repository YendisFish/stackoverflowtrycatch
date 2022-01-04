namespace StackOverFlowTryCatch.Main
{
    public class SOMessage
    {
        public static string Message { get; set; }

        public void SetMessage(string msg) 
        {
            Message = msg;       
        }

        public static SOMessage EmptyMessage()
        {
            SOMessage msg = new();
            return msg;
        }

        public static string GetMessage()
        {
            return Message;
        }
    }
}