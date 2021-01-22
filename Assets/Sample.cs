using UnityEngine;

//SampleクラスでEnemyの関数を実行する
public class Sample : MonoBehaviour
{
    public Enemy enemy;  //Enemyの窓口を作る

    int hp;

    void Attack()
    {
        Debug.Log("攻撃");
    }
    void Heal()
    {
        Debug.Log("回復");
    }

    void Start()
    {
        //Attack();
        //Heal();
        //Debug.Log(hp);
        enemy.Attack();
        Debug.Log(enemy.hp);
    }
}