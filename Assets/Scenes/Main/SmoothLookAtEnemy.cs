using UnityEngine;

public class SmoothLookAtEnemy : MonoBehaviour
{
    public Transform enemy;  // ���� ��ġ
    public float rotationSpeed = 2.0f;  // ȸ�� �ӵ�

    void Update()
    {
        // ���� ���� ���� ���� ���
        Vector3 directionToEnemy = enemy.position - transform.position;

        // ���� ���͸� �������� ��ǥ ȸ�� �� ���
        Quaternion targetRotation = Quaternion.LookRotation(directionToEnemy);

        // ���� ȸ������ ��ǥ ȸ������ �ε巴�� ȸ��
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
