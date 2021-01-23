using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ぶつかったよ");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ぶつかったよーー");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("ぶつかった");
    }
}
