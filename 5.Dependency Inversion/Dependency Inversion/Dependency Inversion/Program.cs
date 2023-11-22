namespace Dependency_Inversion;

internal class Program
{
    static void Main(string[] args)
    {
        //اصل وارونگی وابستگی

        /*
         این اصل شامل دو قانون است : 
        1. ماژول های سطح بالا نباید بصورت مستقیم به ماژول های سطح پایین وابسته باشند بلکه وابستگی این دو باید به وسیله ی واسطی از جنس 
        ابسترکشن کنترل گردد.
        2.ابسترکت ها نباید به جزییات وابسته باشند بلکه جزییات باید به ابسترکشن ها وابسته باشند .
         */


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

    IApplicationLayer_CorrecrtSample _applicationLayer_CorrecrtSample;

    public Presentation_CorrectSample(IApplicationLayer_CorrecrtSample applicationLayer_CorrecrtSample)
    {
        _applicationLayer_CorrecrtSample = applicationLayer_CorrecrtSample;
    }

    public void Sum()
    {
        _applicationLayer_CorrecrtSample.Sum();
    }
}

#endregion