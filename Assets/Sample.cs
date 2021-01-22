using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    
    void Start()
    {
        //関数の使い方
        //関数名();
        //SayName();
        //SayName1("あつ", 20);
        string studioName = GetSayName1("atsu", 3);
        Debug.Log(studioName);
        
    }
    //何も返さないならvoid / string型を返すので　string 関数名()
    string GetSayName1(string userName, int age)
    {
        //Debug.Log("スタジオ" + userName + age + "歳");
        //Debug.Log(userName + "スタジオ");
        return "スタジオ" + userName + age + "周年";
    }

    //引数ありの関数の作成
    void SayName1(string userName, int age)
    {
        Debug.Log("スタジオ" + userName + age + "歳");
        Debug.Log(userName + "スタジオ");
    }

    //関数の作成 　void 関数名() {}
    void SayName()
    {
        Debug.Log("スタジオ");
    }
}