using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : Singleton<GameManagerTest>
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.Test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
