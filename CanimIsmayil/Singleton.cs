namespace CanimIsmayil;

public class Singleton
{
    //task
    //thread
    //race conditaton
    //lock , monitor , mutex , semaphore,semaphoreSlime

    //thread safety

    private static Singleton _instance;

    private static Object _instanceLock = new Object();

    public static Singleton Instance
    {
        get
        {
            lock (_instanceLock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
           
        }
    }
}
