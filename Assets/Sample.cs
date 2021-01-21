using UnityEngine;

public class Sample : MonoBehaviour
{
    // 123かける456割る2の計算結果をコンソールに表示したい
    void Start()
    {
        int hp = 100;

        if (hp <= 0)
        {
            hp = 0;
            Debug.Log("戦闘不能");
        }
        else
        {
            Debug.Log("生きている！");
        }
    }
}
