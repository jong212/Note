using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] Animator Animator_Player;

    public delegate void ImDelegate(int a);
    public static ImDelegate _customDelegate;

    public static Action<int> _customAction;
    private void Start()
    {        
        _customDelegate += InvokeEvent;
        _customAction += InvokeEvent;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _customAction.Invoke(10);
        }
    }

    private void InvokeEvent(int a )
    {
        Debug.Log(a);
        Animator_Player.SetTrigger("Atk");
    }
}
