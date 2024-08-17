using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsMemberOne : MonoBehaviour
{
    [SerializeField] Animator Animator_SubMember;

    private void Awake()
    {
        /*Event._customDelegate += OnEventMakerInvoked;*/
        Event._customAction += OnEventMakerInvoked;
    }
    public void OnEventMakerInvoked(int a)
    {
        Animator_SubMember.SetTrigger("Atk");
    }

}
