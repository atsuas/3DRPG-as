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
    }
}
