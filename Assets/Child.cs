using UnityEngine;

public class Child : Parent
{
    public int �Ű����� = 5;  // �⺻�� ����

    protected override void Awake()
    {
        base.Awake();
        Debug.Log("�ڽ� Awake ȣ��");
        this.�θ��Ǻ��� = �Ű�����;
        Debug.Log("�ڽ� Awake���� �θ��Ǻ��� ����, �θ��Ǻ��� = " + �θ��Ǻ���);
    }

    protected override void Start()
    {
        Debug.Log("�ڽ��� Start() ȣ�� ��");
        base.Start();
        Debug.Log("�ڽ��� Start() ȣ�� ��");
    }
}
