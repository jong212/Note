using System.Collections;
using System.Collections.Generic;

public class EventManager
{
    private static EventManager _instance = null;

    public static EventManager Inst
    {
        get
        {
            if (_instance == null)
            {
                _instance = new EventManager();
            }
            return _instance;
        }
    }
}
