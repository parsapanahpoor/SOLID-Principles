namespace Interface_Segregation_Principle;
internal class Program
{
    static void Main(string[] args)
    {
        //اصل جداسازی اینترفیس ها
        //منظور این است که اینترفیس های خود را بشکلی طراحی نکنید
        //که کلاس های پیاده سازی کننده ی اینترفیس دچار فانکشنالیتی بیش از وظایف خود شوند

        //از نوشتن اینترفیس های چندگانه و پراکنده و بزرگ پرهیز کنیم 
    }
}

#region Wrong Sample

public interface FootballPlayer_WrongSample
{
    void PlayFootball();

    void CleanUpClub();

    void CookFood();
}

public class FootballPlayer1_WrongSample : FootballPlayer_WrongSample
{
    public void CleanUpClub()
    { }

    public void CookFood()
    { }

    public void PlayFootball()
    { }
}

#endregion

#region Correct Sample

public interface FootballPlayer_CorrectSample
{
    void PlayFootball();
}

public interface MasterChef_CorrectSample
{
    void CookFood();
}

public interface HouseKeeper_CorrectSample
{
    void CleanUpClub();
}

public class FootballPlayer1 : FootballPlayer_CorrectSample
{
    public void PlayFootball()
    { }
}

public class MasterChef1 : MasterChef_CorrectSample
{
    public void CookFood()
    { }
}

public class HouseKeeper1 : HouseKeeper_CorrectSample
{
    public void CleanUpClub()
    { }
}

#endregion