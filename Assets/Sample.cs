using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 10;
        int m = -2;
        int l = 3;

        Debug.Log(n > m && m < l);
        Debug.Log(n > m && m > l);
        Debug.Log(n > m || m > l);

    }

}
