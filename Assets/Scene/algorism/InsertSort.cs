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
        // i��ȸ
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

        // �迭�� ù ��° ��Ҵ� �̹� ���ĵ� ���·� �����ϹǷ�, i�� 1���� ����
        for (i = 1; i < arr2.Length; i++)
        {            
            // i�� ����
            temp = arr2[i];

            // ���� ���� 33,22,11 �� �迭�̸� ���� j�� 22�̰� ������ j-1�� 33 �̴ϱ� 
            // j-1�� j�� ����� �Ѵ� �׷� 33 33 11�� �ǰ��� 
            // ���⼭ �߿��� ���� j�� �ٽ� �� �� for���� ���鼭 j--�� ���� 1���� 0�� �Ǿ��ٴ� ���̰� �׷� ���� j�� 0�� ��� ���̴�
            // �������̳ĸ� j�� 0 �̸� arr[j] = temp; �ع����� �Ʊ� 22�� arr 0�ڸ��� ���ϱ� �ٽ� 22 33 11 �� �Ǵ� ���̴�.

            //�׸��� ���� �ٱ� for���� ���� ���� for���� j�� 2�� ���۵ǰ� 
            // arr2[2-1] �� 11���� ũ�ϱ� 22 33 33�� �ǰ�
            // arr2[1-1] �� 22�ϱ� �굵 11���� ũ�ϱ� 22 22 33�� �ǰ�
            // �ᱹ j�� 2�� ���������� ������ for���� Ż �� 0�� �Ǿ arr2[0] = temp�� ���� 11 22 33�� �Ǵ� ��.,..
            for (j = i; j > 0 && (arr2[j - 1] > temp); j--)
            {                
                arr2[j] = arr2[j - 1];
            }

            // ���� ���� for ���� ���� �ʾҴٸ� temp�� ���� �״�� �� j�ڸ��� ����� ���̴� 
            // ������ for���� ���Ҵٸ� �� �ڸ��� �� ��ŭ �������� �̵��ϰ� �̵��� �ڸ��� temp���� �־��� ���̴�
            arr2[j] = temp;
        }
    }

}
