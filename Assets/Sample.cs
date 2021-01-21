using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    List<string> nameList = new List<string> { "スタジオしまづ", "アンチスタジオしまづ", "しまづ" };

    void Start()
    {
        // nameListの"アンチスタジオしまづ"を消したい
        nameList.Remove("アンチスタジオしまづ");
        
    }
}