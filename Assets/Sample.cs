﻿using UnityEngine;

public class Question : MonoBehaviour
{
    void Start()
    {
        for (int i = 1000; i <= 2000; i++)
        {
            Debug.Log(i);

            if (i % 273 == 0)
            {
                break;
            }
        }
    }
}
