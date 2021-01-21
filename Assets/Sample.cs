using UnityEngine;

public class Sample : MonoBehaviour
{
    enum DIRECTION
    {
        STOP,
        RIGHT,
        LEFT,
        TOP,
        BOTTOM
    }

    DIRECTION direction;

    void Start()
    {
        direction = DIRECTION.LEFT;
        Debug.Log((int)direction);  //intを付けると配列の数値が返ってくる

        switch (direction)
        {
            case DIRECTION.STOP:
                Debug.Log("停止");
                break;
            case DIRECTION.RIGHT:
                Debug.Log("右");
                break;
            case DIRECTION.LEFT:
                Debug.Log("左");
                break;
            case DIRECTION.TOP:
                Debug.Log("上");
                break;
            case DIRECTION.BOTTOM:
                Debug.Log("下");
                break;
        }
    }
}
