namespace Coupling;

internal class Program
{
    static void Main(string[] args)
    {
    }
}


#region Tight Coupling - اتصال محکم

public class Yahoo {}

public class SendEmail : Yahoo
{
    public void Send(Yahoo gmail) { }

    public List<Yahoo> GetInputs()
    {
        return new List<Yahoo>();
    }
}

#endregion


#region Low Coupling - اتصال سست

public interface ISendMessage
{
    void Execute();
}

public class SendGmail : ISendMessage
{
    public void Execute() {}
}

public class SendYahoo : ISendMessage
{
    public void Execute() { }
}

#endregion