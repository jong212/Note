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
        EventManager.Inst.RequestSubscribe(true, OnEventMakerInvoked);
    }

    private void OnDisable()
    {
        EventManager.Inst.RequestSubscribe(false, OnEventMakerInvoked);
    }


    public void OnEventMakerInvoked()
    {
        Animator_SubMember.SetTrigger("Atk");
    }

}
