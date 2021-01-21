using UnityEngine;

public class Sample : MonoBehaviour
{
    
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i == 3)
            {
                //break; //処理を抜ける
                continue; //一回飛ばす
            }
            
        }
        Debug.Log("魔法攻撃");
    }
}
