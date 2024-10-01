using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class InsertSort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] _arr = { 3, 5,6, 2, 1, 7,9, 0, 11 };
        SortTest1(_arr);
        foreach( int i in _arr) { Debug.Log("test1 :" + i); }
        
        int[] _arr2 = {1,2,34,5,6,7,8,9};
        SortTest2(_arr2);
        foreach( int i in _arr2) { Debug.Log("test2 :" + i); }

    }
 
    void SortTest1(int[] arr)
    {
        int len = arr.Length;
        int j;
        // i순회
        // j
        for(int i = 0; i < len -1; i++)
        {
            j = i;
            while (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                if(j != 0) j--;

            }
        }
    }
    void SortTest2(int[] arr2)
    {
        int i, j, temp;

        // 배열의 첫 번째 요소는 이미 정렬된 상태로 간주하므로, i는 1부터 시작
        for (i = 1; i < arr2.Length; i++)
        {            
            // i값 저장
            temp = arr2[i];

            // 만약 값이 33,22,11 인 배열이면 현재 j가 22이고 좌측값 j-1이 33 이니까 
            // j-1을 j에 덮어야 한다 그럼 33 33 11이 되겠지 
            // 여기서 중요한 것은 j가 다시 한 번 for문을 돌면서 j--로 인해 1에서 0이 되었다는 것이고 그로 인해 j는 0이 라는 것이다
            // 무슨말이냐면 j가 0 이면 arr[j] = temp; 해버리면 아까 22가 arr 0자리에 들어가니까 다시 22 33 11 이 되는 것이다.

            //그리고 나서 바깥 for문을 돌면 안쪽 for문의 j는 2로 시작되고 
            // arr2[2-1] 이 11보다 크니까 22 33 33이 되고
            // arr2[1-1] 이 22니까 얘도 11보다 크니까 22 22 33이 되고
            // 결국 j는 2로 시작했지만 마지막 for문을 탈 때 0이 되어서 arr2[0] = temp로 인해 11 22 33이 되는 것.,..
            for (j = i; j > 0 && (arr2[j - 1] > temp); j--)
            {                
                arr2[j] = arr2[j - 1];
            }

            // 만약 위의 for 문을 돌지 않았다면 temp의 값이 그대로 내 j자리에 적용될 것이다 
            // 하지만 for문을 돌았다면 내 자리가 돈 만큼 왼쪽으로 이동하고 이동된 자리에 temp값이 넣어질 것이다
            arr2[j] = temp;
        }
    }

}
