using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 100;
    int at = 10;

    public void Attack()
    {
        Debug.Log("Enemyの攻撃");
    }
    void Heal()
    {
        Debug.Log("Enemyの回復");
    }
}
