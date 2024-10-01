using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSort : MonoBehaviour
{
    // Start()는 Unity에서 스크립트가 실행될 때 처음 호출되는 함수입니다.
    void Start()
    {
        // 정렬할 배열을 초기화합니다.
        int[] _arr = { 64, 25, 12, 22, 11 };

        // 선택 정렬 함수를 호출하여 배열을 정렬합니다.
        StartSorting(_arr);

        // 정렬된 배열의 결과를 출력합니다.
        foreach (int item in _arr)
        {
            Debug.Log("ArrayResult::" + item);  // 각 배열 요소를 Unity 콘솔에 출력
        }
    }

    // 선택 정렬 알고리즘을 구현한 함수입니다.
    void StartSorting(int[] arr)
    {
        // 배열의 길이를 구하여 변수 n에 저장합니다.
        int n = arr.Length;

        // 외부 반복문: 배열의 첫 번째 요소부터 마지막에서 두 번째 요소까지 반복합니다.
        // n-1까지 반복하는 이유는 마지막 두 요소는 자동으로 정렬되기 때문입니다.
        for (int i = 0; i < n - 1; i++)
        {
            // 현재 인덱스를 최소값의 인덱스로 가정합니다.
            int minIndex = i;

            // 내부 반복문: 현재 위치 이후의 요소들 중 최소값을 찾습니다.
            // j = i + 1이기 때문에 현재 위치 다음 요소부터 비교를 시작합니다.
            for (int j = i + 1; j < n; j++)
            {
                // arr[j]가 현재까지의 최소값(arr[minIndex])보다 작으면 최소값의 인덱스를 업데이트합니다.
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;  // 새로운 최소값의 인덱스를 저장합니다.
                }
            }

            // 최소값이 현재 위치의 값과 다르다면 값을 교환합니다.
            if (minIndex != i)
            {
                // arr[minIndex]와 arr[i]를 교환하여 최소값을 올바른 위치로 보냅니다.
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }

    // Update()는 Unity에서 매 프레임마다 호출되는 함수입니다. 여기서는 사용하지 않지만 기본적으로 포함됩니다.
    void Update()
    {
        // 이 함수는 프레임마다 반복적으로 호출되지만, 이 코드에서는 아무 작업도 하지 않습니다.
    }
}
