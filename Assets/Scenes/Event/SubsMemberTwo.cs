using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubsMemberTwo : MonoBehaviour
{
    [SerializeField] Animator Animator_SubMember;

    private void Awake()
    {
        /*Event._customDelegate += OnEventLalala;*/
        Event._customAction += OnEventLalala;
    }
    public void OnEventLalala()
    {
        Animator_SubMember.SetTrigger("LevelUp");
    }
}
