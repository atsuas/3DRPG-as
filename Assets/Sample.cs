using UnityEngine;

public class Sample : MonoBehaviour
{
    // 123かける456割る2の計算結果をコンソールに表示したい
    void Start()
    {
        int n = 123;
        int m = 456;

        Debug.Log(n * m / 2);
    }
}
