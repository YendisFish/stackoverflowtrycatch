using StackOverFlowTryCatch.Main;
using System.Diagnostics;

namespace StackOverFlowTryCatch
{
    public class SOTryCatch<T>
    {
        public SOMessage Handle(Func<T> function)
        {
            try
            {
                if(function is not null)
                {
                    Executor(() => function());
                }
            } catch(Exception ex)
            {
                SOMessage ret = new SOMessage();
                ret.SetMessage(ex.Message.ToString());

                try
                {
                    ProcessStartInfo inf = new();
                    inf.FileName = "firefox";
                    inf.Arguments = $"https://stackoverflow.com/search?q={ex.Message.ToString()}";
                }catch(Exception ex2) 
                {
                    Console.WriteLine("StackOverflow try-catch failed.");
                }

                return ret;
            }

            return SOMessage.EmptyMessage();
        }

        public static void Executor(Action action)
        {
            action();
        }
    }
}