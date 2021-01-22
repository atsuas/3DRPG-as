using UnityEngine;

public class Sample : MonoBehaviour
{
    public Player player;

    void Start()
    {
        //ここでPlayerのAttack関数を実行したい
        player.Attack();
    }
}