using UnityEngine;

public class Sample : MonoBehaviour
{
    
    void Start()
    {
        int n = 3;

        if (n > 10)
        {
            Debug.Log("nは10より大きい");
        }
        else if (n > 0)
        {
            Debug.Log("nは0より大きい");
        }
        else
        {
            Debug.Log("その他");
        }
    }
}
