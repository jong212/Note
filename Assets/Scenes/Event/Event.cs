using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour, IEvenMake
{
    [SerializeField] Animator Animator_Player;

    Action _eventInvokHandler;

    private void Start()
    {
        EventManager.Inst.RegisterCurEventmaker(true, this);
    }

    private void OnDisable()
    {
        _eventInvokHandler = null;
    }

    // ���� Subscribe���� Register �Ǵ� AddEvent ���� �� ���� - ������ �����̶�� �ǹ̷� �׳� ���
    public void Subscribe(bool isSubscribe, Action callback)
    {
        if (isSubscribe)
            _eventInvokHandler += callback;
        else
            _eventInvokHandler -= callback;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeEvent();
        }
    }

    private void InvokeEvent()
    {
        Animator_Player.SetTrigger("Atk");

        if (_eventInvokHandler != null)
            _eventInvokHandler.Invoke();
    }
}
