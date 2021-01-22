using UnityEngine;

public class Sample : MonoBehaviour
{
    int x = 10;
    int y = 2;

    void Start()
    {
        Goto();
    }

    void Goto()
    {
        Debug.Log(x + y);
    }
}