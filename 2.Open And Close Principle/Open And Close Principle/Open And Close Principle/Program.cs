namespace Single_Responsibility_Principle;

public class Program
{
    static void Main(string[] args)
    {
        //تمام آبجکت ها باید برای تغییر بسته و برای گسترش باز باشند.
        // به زبان ساده : چیزی رو تغییر ندید و بلکه آن را گسترش بدید

        //ارائه شده توسط مایر در دهه ی 1980

        //همانند دیزاین پترن رپر یا دیکوریتور که به کلاس اصلی امکاناتی را اضافه میکند بدون اینکه مستقیما آن کلاس را تغییر بدهد.

        /*
         برای مثال پیتزای پپرونی رو در نظر بگیرید . هر فردی بسته به علاقه ی شخصی میتونه پیتزا پپرونی رو شخصی سازی کنه . مثلا من دوست دارم 
        روی این پیتزا زیتون سیاه بریزم ولی برادرم علاقه ای به ریختن زیتون نداره . من و برادرم میتونیم این پیتزا رو گسترش بدیم اما حق نداریم دستور 
        اصلی این پیتزا که شامل سوسیس پپرونی هستش رو تغییر بدیم . در واقع اگر ما پپرونی رو از این پیتزا حذف کنیم این اصل رو زیر پا گذاشتیم 
         */
    }
}

//Wrong Sample - نمونه ی اشتباه 
public class PeperoniPizza_WrongSample
{
    public string Peperoni { get; set; }

    #region تغییرات من 

    public string Olive { get; set; }

    #endregion

    #region تغییرات برادرم 

    public string MoreCheese { get; set; }

    #endregion
}

//Correct Sample - نمونه ی درست
public class PeperoniPizza_CorrectSample
{
    public string Peperoni { get; set;}
}

//درحال گسترش کلاس 
public class ParsaPanahpoor_PeperoniPizza : PeperoniPizza_CorrectSample
{
    public string Olive { get; set; }
}

//درحال گسترش کلاس 
public class NimaPanahpoor_PeperoniPizza : PeperoniPizza_CorrectSample
{
    public string MoreCheese { get; set; }
}