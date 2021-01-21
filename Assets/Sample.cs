using UnityEngine;

public class Sample : MonoBehaviour
{
    
    void Start()
    {
        string direction = "右";
        switch (direction)
        {
            case "右":
                Debug.Log("入力が右");
                break;
            case "左":
                Debug.Log("入力が左");
                break;
            case "停止":
                Debug.Log("入力が停止");
                break;
            default:
                Debug.Log("その他");
                break;  
        }
    }
}
