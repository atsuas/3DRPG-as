﻿using UnityEngine;

public class Sample : MonoBehaviour
{
    int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[] numbers2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    void Start()
    {
        for (int i = 0; i < numbers1.Length; i++)
        {
            Debug.Log(numbers1[i]);
        }
        for (int i = 0; i < numbers2.Length; i++)
        {
            Debug.Log(numbers2[i]);
        }
    }

    void ShowArrayValueLog()
    {

    }
}