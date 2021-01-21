using UnityEngine;

public class Sample : MonoBehaviour
{
    int hp = 100;
    void Start()
    {
        if (hp <= 0)
        {
            Debug.Log("戦闘不能");
        }
    }
}
