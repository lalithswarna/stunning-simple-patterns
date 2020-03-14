//thread is locked on a shared object and checks whether an instance has been created or not with double checking
// Bad Code Do not Use!!
public sealed class SingletonDoubleCheck  
{  
    SingletonDoubleCheck()  
    {  
    }  
    private static readonly object padlock = new object();  
    private static SingletonDoubleCheck instance = null;  
    public static SingletonDoubleCheck Instance  
    {  
        get  
        {  
            if (instance == null)  
            {  
                lock (padlock)  
                {  
                    if (instance == null)  
                    {  
                        instance = new SingletonDoubleCheck();  
                    }  
                }  
            }  
            return instance;  
        }  
    }  
}