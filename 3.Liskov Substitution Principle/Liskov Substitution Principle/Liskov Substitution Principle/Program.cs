namespace Single_Responsibility_Principle;

public class Program
{
    static void Main(string[] args)
    {
        //اصل جایگزینی لیسکاو 
        //این اصل میگوید که کلاس های فرزند نباید بتوانند رفتار و اخلاق کلاس های والد را تغییر بدهند. 

        //فکت : در زمان نمونه سازی کلاس های فرزند می توانند بجای کلاس های والد نوشته شوند

        #region Test Of Wrong Sample 

        //اول بخاطر بسپارید که این نوع جایگزینی غلط سینتکسی است.
        //Orange orange = new Apple();

        Apple apple = new Orange(); 

        apple.GetFruitName();
        //در اینجا انتظار داریم نام اپل چاپ گردد درحالی که نام اورنج چاپ میشود .
        //در اینجا کلاس فرزند رفتار و اخلاق کلاس پدر را تغییر داده که درست نیست

        #endregion

        #region Test Correct Sample

        //یادمان باشد کلاس های ابسترکت و اینترفیس را نمی توان به صورت مستقیم نمونه سازی کرد.
        //Food Food = new Food();

        Food pizza = new Pizza();

        Food pasta = new Pasta();

        pizza.GetFoodName();

        pasta.GetFoodName();

        //هیچکدام از دو متود بالایی رفتار اینترفیس والد را تغییر نداده اند بلکه در درون بدنه ی خود آن را پیاده سازی کرده اند.

        #endregion
    }
}

#region Wrong Sample 

public class Apple
{
    public virtual void GetFruitName()
    {
        Console.WriteLine("Red");
    }
}

public class Orange : Apple
{
    public override void GetFruitName()
    {
        Console.WriteLine("Orange");
    }
}

#endregion

#region Correct Sample 

public interface Food
{
    void GetFoodName();
}

public class Pizza : Food
{
    public void GetFoodName()
    {
        Console.WriteLine("Pizza");
    }
}

public class Pasta : Food
{
    public void GetFoodName()
    {
        Console.WriteLine("Pasta");
    }
}

#endregion