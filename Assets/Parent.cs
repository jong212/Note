using UnityEngine;

public class Parent : MonoBehaviour
{
    protected int 부모의변수;

    protected virtual void Awake()
    {
        Debug.Log("부모 Awake 호출");
    }

    protected virtual void Start()
    {
        부모의변수 = 1;
        Debug.Log("부모의 Start() 호출, 부모의변수 = " + 부모의변수);
    }
}
