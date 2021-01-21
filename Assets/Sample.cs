using UnityEngine;

public class Sample : MonoBehaviour
{
    int count = 10;

    void Start()
    {
       while (count <= 1000)
        {
            Debug.Log(count);
            count = count + 1;
        }
    }
}
