using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] Animator Animator_Player;

    public delegate void ImDelegate();
    public static ImDelegate _customDelegate;

    private void Start()
    {
        /* _customDelegate = new ImDelegate(InvokeEvent);*/
        _customDelegate += InvokeEvent;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _customDelegate();
        }
    }

    private void InvokeEvent()
    {
        Animator_Player.SetTrigger("Atk");
    }
}
