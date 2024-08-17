using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    [SerializeField] SubsMemberOne Member_One;
    [SerializeField] SubsMemberTwo Member_Two;
    [SerializeField] Animator Animator_Player;

    delegate void ImDelegate();
    ImDelegate _customDelegate;

    private void Start()
    {
        _customDelegate = new ImDelegate(InvokeEvent);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _customDelegate += InvokeEventTwo;
            //InvokeEvent();
            _customDelegate();

            _customDelegate -= InvokeEventTwo;
        }
    }

    private void InvokeEventTwo()
    {
        Animator_Player.SetTrigger("LevelUp");
    }

    private void InvokeEvent()
    {
        Animator_Player.SetTrigger("Atk");

        if (Member_One)
            Member_One.OnEventMakerInvoked();

        if (Member_Two)
            Member_Two.OnEventLalala();
    }
}
