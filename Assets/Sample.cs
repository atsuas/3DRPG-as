using UnityEngine;

public class Sample : MonoBehaviour
{
    // 123かける456割る2の計算結果をコンソールに表示したい
    void Start()
    {
        int hp = -2;

        if (hp <= 0)
        {
            hp = 0;
        }
        Debug.Log(hp);
    }
}
