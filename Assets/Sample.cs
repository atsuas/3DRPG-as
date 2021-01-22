using UnityEngine;

public class Sample : MonoBehaviour
{
    void Start()
    {
        Move(0, 19);  // 上
        Move(0, -1);  // 下
        Move(20, 0);  // 右
        Move(-20, 0); // 左
        Move(0, 0);   // 停止
        Move(-1, -1);   // その他
    }

    void Move(int x, int y)
    {
        if (x == 0 && y > 0)
        {
            Debug.Log("上");
        }
        else if (x == 0 && y < 0)
        {
            Debug.Log("下");
        }
        else if (x > 0 && y == 0)
        {
            Debug.Log("右");
        }
        else if (x < 0 && y == 0)
        {
            Debug.Log("左");
        }
        else if (x == 0 && y == 0)
        {
            Debug.Log("停止");
        }
        else
        {
            Debug.Log("その他");
        }
        
    }
}
