using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    List<string> nameList = new List<string> { "スタジオしまづ", "嶋津恒彦", "しまづ" };
    void Start()
    {
        // コンソールに0番目を表示したい
        Debug.Log(nameList[0]);
        // 0番目の値を"スタジオしまづアカデミア"に変更したい
        nameList[0] = "スタジオしまづアカデミア";
        // コンソールに0番目を表示したい
        Debug.Log(nameList[0]);
    }
}