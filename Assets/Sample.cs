using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    List<string> nameList = new List<string> { "スタジオしまづ", "嶋津恒彦", "しまづ" };

    void Start()
    {
        // nameListに"スタジオしまづアカデミア"を追加したい：Addってのを使う
        nameList.Add("スタジオしまづアカデミア");

        // 追加したあと、全ての値をログに表示して追加されたのを確認したい
        for (int i = 0; i < nameList.Count; i++)
        {
            Debug.Log(nameList[i]);
        }
    }
}