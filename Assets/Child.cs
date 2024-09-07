using UnityEngine;

public class Child : Parent
{
    public int 매개변수 = 5;  // 기본값 설정

    protected override void Awake()
    {
        base.Awake();
        Debug.Log("자식 Awake 호출");
        this.부모의변수 = 매개변수;
        Debug.Log("자식 Awake에서 부모의변수 설정, 부모의변수 = " + 부모의변수);
    }

    protected override void Start()
    {
        Debug.Log("자식의 Start() 호출 전");
        base.Start();
        Debug.Log("자식의 Start() 호출 후");
    }
}
