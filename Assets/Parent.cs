using UnityEngine;

public class Parent : MonoBehaviour
{
    protected int �θ��Ǻ���;

    protected virtual void Awake()
    {
        Debug.Log("�θ� Awake ȣ��");
    }

    protected virtual void Start()
    {
        �θ��Ǻ��� = 1;
        Debug.Log("�θ��� Start() ȣ��, �θ��Ǻ��� = " + �θ��Ǻ���);
    }
}
