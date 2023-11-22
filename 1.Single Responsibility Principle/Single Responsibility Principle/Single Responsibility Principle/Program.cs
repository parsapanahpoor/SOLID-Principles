namespace Single_Responsibility_Principle;

public class Program
{
    static void Main(string[] args)
    {
        //منظور از اصل تک مسئولیتی این است که هر ماژول شما باید تنها و تنها یک کار را انجام دهد.
        //هر ماژول باید یک دلیل برای تغییر داشته باشد
        //هر ماژول باید به یک اکتور خدمات بدهد 

        //Single Method != Sigle Responsibility
        //Single Task == Single Responsibility 

        /*  
         به عنوان مثال یک رستوران را درنظر بگیرید . مسئولیت سرآشپز در یک رستوران درست کردن غذا می باشد . 
        حال اگر سرآشپز شما هم وظیفه درست کردن غذا و هم وظیفه ی مدیریت امور مالی را بر عهده بگیرد دیگر اصل تک مسئولیتی را نقض کرده ایم .
        در واقع وظیفه ی آشپز پخت غذاست و نیز مدیریت مالی بر عهده ی حساب دار است.
         */
    }
}

//Bad Sample - مثال نادرست
public class MasterChef_MultyResponsibility
{
    public void CookingFood(){ }
    
    public void FinancialAccounting() { }
}

//Correct Sample - مثال درست
public class MasterChef_SingleResponsibility
{
    public void CookingFood() { }
}

//Correct Sample - مثال درست
public class Accountant_SingleResponsibility
{
    public void FinancialAccounting() { }
}
