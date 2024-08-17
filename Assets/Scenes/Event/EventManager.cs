using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

// �̺�Ʈ ������û�� RegisterCurEventmaker �������� 
// ���� ��û�� ���� ���� �̺�Ʈ ������ ������ _currentEventMaker ������ ������

public interface IEvenMake
{
    public void Subscribe(bool isSubscribe, Action callback);
}
public class EventManager
{
    private static EventManager _instance = null;

    private IEvenMake _currentEventMaker; // ���� �̺�Ʈ ��ü�� ������?
    private List<Action> _actionSubscribeRequestList = new List<Action>(); // 

    public void RegisterCurEventmaker(bool isRegister, IEvenMake eventMaker)
    {
        if(isRegister)
        {
             _currentEventMaker = eventMaker;
            CheckSubscribeRequestList();
        }
        else
        {
            _currentEventMaker = null;
        }
    }
    private void CheckSubscribeRequestList()
    {
        if (_actionSubscribeRequestList.Count > 0)
        {
            foreach (var action in _actionSubscribeRequestList)
            {
                _currentEventMaker.Subscribe(true, action);
            }
            _actionSubscribeRequestList.Clear();
        }
    }

    public void RequestSubscribe(bool isSubscribe, Action callback)
    {
        if(_currentEventMaker == null)
        {
            _actionSubscribeRequestList.Add(callback);
            return;
        }
        _currentEventMaker.Subscribe(isSubscribe, callback);
    }
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
