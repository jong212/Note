using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

// 이벤트 구독요청은 RegisterCurEventmaker 이쪽으로 
// 구독 요청이 오면 실제 이벤트 구독이 가능한 _currentEventMaker 곳으로 보내줌

public interface IEvenMake
{
    public void Subscribe(bool isSubscribe, Action callback);
}
public class EventManager
{
    private static EventManager _instance = null;

    private IEvenMake _currentEventMaker; // 현재 이벤트 객체가 누구냐?
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
