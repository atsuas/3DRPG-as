﻿using UnityEngine;

public class Question : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Debug.Log(i);
        }
    }
}
