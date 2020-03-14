// Use a static constructor 
//static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain
public sealed class ThreadSafeWithoutLocks{
    private static readonly ThreadSafeWithoutLocks instance = new ThreadSafeWithoutLocks();

    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static ThreadSafeWithoutLocks()    {
    }

    private ThreadSafeWithoutLocks()    {
    }

    public static ThreadSafeWithoutLocks Instance    {
        get
        {
            return instance;
        }
    }
}