using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnQueue : MonoBehaviour
{
    // 내부적으로 사용할 큐
    private Queue<GameObject> enemyQueue = new Queue<GameObject>();

    public Transform spawnPoint;    // 스폰 위치
    public GameObject enemyPrefab;  // 적 프리팹
    public float spawnInterval = 1.5f;  // 스폰 간격 (1.5초)

    private void Start()
    {
        // 큐에 5개의 적을 미리 추가
        for (int i = 1; i <= 500; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.name = "Enemy " + i;  // 적의 이름 지정
            enemy.SetActive(false);     // 비활성화된 상태로 큐에 추가
            enemyQueue.Enqueue(enemy);  // 큐에 적 추가
        }

        // 스폰 시작
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (enemyQueue.Count > 0)
        {
            // 큐에서 적을 꺼내 스폰
            GameObject enemy = enemyQueue.Dequeue();
            enemy.transform.position = spawnPoint.position;
            enemy.SetActive(true);  // 적 활성화

            Debug.Log(enemy.name + " 스폰됨!");  // 스폰된 적 이름 출력

            // 스폰 간격만큼 대기
            yield return new WaitForSeconds(spawnInterval);
        }

        Debug.Log("모든 적이 스폰되었습니다.");
    }
}
