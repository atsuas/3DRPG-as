﻿using UnityEngine;

public class Question : MonoBehaviour
{
    int x = 10;
    int y = 2;
    int z = -3;

    void Start()
    {
        Sample(x, y);
        Sample(y, z);
        Sample(z, x);
    }

    void Sample(int a, int b)
    {
        Debug.Log(a + b);
    }
}