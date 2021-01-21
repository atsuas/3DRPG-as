using UnityEngine;

public class Sample : MonoBehaviour
{
    
    void Start()
    {
        int mp = 10;
        while (mp > 0)
        {
            mp--;   //mp消費  必ず書かないと無限ループになってUnityが止まってしまう
            Debug.Log("mp消費");
            Debug.Log("魔法攻撃");
        }
    }
}
