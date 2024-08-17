using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] Animator Animator_Player;

    public delegate void ImDelegate();
    ImDelegate _delegate;

    private void Start()
    {
    }

    // ���� Subscribe���� Register �Ǵ� AddEvent ���� �� ���� - ������ �����̶�� �ǹ̷� �׳� ���
    public void Subscribe(bool isSubscribe, ImDelegate callback)
    {
        if (isSubscribe)
            _delegate += callback;
        else
            _delegate -= callback;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeEvent();
        }
    }

    private void InvokeEventTwo()
    {
        Animator_Player.SetTrigger("LevelUp");
    }

    private void InvokeEvent()
    {
        Animator_Player.SetTrigger("Atk");
        _delegate();
        //_delegate.Invoke();
    }
}
