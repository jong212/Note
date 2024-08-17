using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SubsMemberTwo : MonoBehaviour
{
    [SerializeField] Event EventMaker_Publisher;
    [SerializeField] Animator Animator_SubMember;

    private void OnEnable()
    {
        var gObj = GameObject.Find("Invoker");
        EventMaker_Publisher = gObj.GetComponent<Event>();

        if (EventMaker_Publisher != null)
        {
            EventMaker_Publisher.Subscribe(isSubscribe: true, OnEventMakerLalala);
        }
    }

    private void OnDisable()
    {
        if (EventMaker_Publisher != null)
        {
            EventMaker_Publisher.Subscribe(isSubscribe: false, OnEventMakerLalala);
        }

    }

    public void OnEventMakerLalala()
    {
        Animator_SubMember.SetTrigger("LevelUp");
    }

}
