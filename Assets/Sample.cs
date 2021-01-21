using UnityEngine;

public class Question : MonoBehaviour
{
    int hp = 100;
    void Start()
    {
        if (hp <= 0)
        {
            Debug.Log("戦闘不能");
        }
        else
        {
            Debug.Log("元気");
        }
    }
}
