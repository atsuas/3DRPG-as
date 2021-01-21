using UnityEngine;

public class Question : MonoBehaviour
{
    enum Direction
    {
        UP,
        DOWN,
        RIGHT,
        LEFT,
    }

    Direction direction = Direction.RIGHT;
    void Start()
    {
        switch (direction)
        {
            case Direction.UP:
                Debug.Log("上");
                break;
            case Direction.DOWN:
                Debug.Log("下");
                break;
            case Direction.LEFT:
                Debug.Log("左");
                break;
            case Direction.RIGHT:
                Debug.Log("右");
                break;
            default:
                Debug.Log("その他");
                break;
        }
    }
}
