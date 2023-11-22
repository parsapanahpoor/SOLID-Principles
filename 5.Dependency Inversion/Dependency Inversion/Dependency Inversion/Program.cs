namespace Dependency_Inversion;

internal class Program
{
    static void Main(string[] args)
    {
        //اصل وارونگی وابستگی
    }
}

#region Wrong Sample 

public class ApplicationLayer_WrongSample
{
    public void Sum() { }
}

public class Presentation_WrongSample
{
    ApplicationLayer_WrongSample _applicationLayer = new ApplicationLayer_WrongSample();

    public void Sum()
    {
        _applicationLayer.Sum();
    }
}

#endregion

#region Correct Sample 

public interface IApplicationLayer_CorrecrtSample
{
    void Sum();
}

public class ApplicationLayer_CorrecrSample : IApplicationLayer_CorrecrtSample
{
    public void Sum() { }
}

public class Presentation_CorrectSample
{
    //Dependency Injection

    IApplicationLayer_CorrecrtSample applicationLayer_CorrecrtSample;

    public Presentation_CorrectSample()
    {
        
    }
}

#endregion