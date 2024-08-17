using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SubsMemberOne : MonoBehaviour
{
    [SerializeField] Event EventMaker_Publisher;
    [SerializeField] Animator Animator_SubMember;

    private void OnEnable()
    {
        var gObj = GameObject.Find("Invoker");
        EventMaker_Publisher = gObj.GetComponent<Event>();

        if (EventMaker_Publisher != null)
        {
            EventMaker_Publisher.Subscribe(isSubscribe: true, OnEventMakerInvoked);
        }
    }

    private void OnDisable()
    {
        if (EventMaker_Publisher != null)
        {
            EventMaker_Publisher.Subscribe(isSubscribe: false, OnEventMakerInvoked);
        }

    }

    public void OnEventMakerInvoked()
    {
        Animator_SubMember.SetTrigger("Atk");
    }

}
