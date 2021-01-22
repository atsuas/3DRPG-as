﻿using UnityEngine;

public class Sample : MonoBehaviour
{

    void Start()
    {
        int sum = 0;
        sum += Damage("しまづ", 100);
        sum += Damage("しまづ", 20);

        // sum = 100+20; //100とか20が変わるたびに修正しないといけないのでミスが起こりやすい
        Debug.Log("合計のダメージは" + sum + "です");
    }

    int Damage(string target, int damage)
    {
        Debug.Log(target + "は" + damage + "をうけました。");
        return damage;
    }
}