using UnityEngine;

public class Sample : MonoBehaviour
{
    void Start()
    {
        Goto1(10, 2, -3);
    }

    void Goto1(int x, int y, int z)
    {
        Debug.Log(x + y);
        Debug.Log(y + z);
        Debug.Log(z + x);
    }
}