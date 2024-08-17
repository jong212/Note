using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] Animator Animator_Player;

    public delegate void ImDelegate();
    public static ImDelegate _customDelegate;

    public static Action _customAction;
    private void Start()
    {        
        _customDelegate += InvokeEvent;
        _customAction += InvokeEvent;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _customAction.Invoke();
        }
    }

    private void InvokeEvent()
    {
        Animator_Player.SetTrigger("Atk");
    }
}
