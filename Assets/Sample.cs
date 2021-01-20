using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 10;

        n = n + 1;
        n += 1;
        n++;
        Debug.Log(n);
    }

}
