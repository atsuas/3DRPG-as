﻿using UnityEngine;

public class Question : MonoBehaviour
{
    enum Direction
    {
        UP,
        DOWN,
        RIGHT,
        LEFT
    }

    int direction = 0;
    void Start()
    {
        switch (direction)
        {
            case 0:
                Debug.Log("上");
                break;
            case 1:
                Debug.Log("下");
                break;
            case 2:
                Debug.Log("左");
                break;
            case 3:
                Debug.Log("右");
                break;
            default:
                Debug.Log("その他");
                break;
        }
    }
}
