﻿using UnityEngine;

public class Sample : MonoBehaviour
{
    // 名前：スタジオしまづ
    // 身長：163.0cm
    // 体重：44.5kg
    // 誕生日：5月7日
    string myName = "スタジオしまづ";
    float height = 163.0f;
    int weight = 45;
    int monthOfbirth = 5;
    int dayOfbirth = 7;

    void Start()
    {
        Debug.Log("名前：" + myName);
        Debug.Log("身長：" + height);
        Debug.Log("体重：" + weight);
        Debug.Log("誕生日：" + monthOfbirth + "月" + dayOfbirth + "日");
    }
}
