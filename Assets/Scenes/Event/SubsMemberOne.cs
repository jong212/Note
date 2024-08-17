using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsMemberOne : MonoBehaviour
{
    [SerializeField] Animator Animator_SubMember;

    private void Awake()
    {
        Event._customDelegate += OnEventMakerInvoked;
    }
    public void OnEventMakerInvoked()
    {
        Animator_SubMember.SetTrigger("Atk");
    }

}
