using UnityEngine;

public class SmoothLookAtEnemy : MonoBehaviour
{
    public Transform enemy;  // 적의 위치
    public float rotationSpeed = 2.0f;  // 회전 속도

    void Update()
    {
        // 적을 향한 방향 벡터 계산
        Vector3 directionToEnemy = enemy.position - transform.position;

        // 방향 벡터를 기준으로 목표 회전 값 계산
        Quaternion targetRotation = Quaternion.LookRotation(directionToEnemy);

        // 현재 회전에서 목표 회전으로 부드럽게 회전
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
