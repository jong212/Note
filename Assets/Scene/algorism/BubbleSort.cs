using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    
    void Start()
    {
        int[] intArr = { 1, 2, 11, 3, 5, 4, 33, 8 };

        PlayBubbleSort(intArr);

        foreach(int i in intArr)
        {
            Debug.Log(i);
        }
    }

    private void PlayBubbleSort(int[] intArr)
    {
        int i, j, temp;
        for(i = 0; i < intArr.Length -1; i++)
        {
            for(j = 0; j < intArr.Length -1 -i; j++)
            {
                if (intArr[j] > intArr[j + 1])
                {
                    temp = intArr[j];
                    intArr[j] = intArr[j + 1];
                    intArr[j + 1] = temp;
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
