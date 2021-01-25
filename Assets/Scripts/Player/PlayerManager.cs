using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    float x;
    float z;
    public float moveSpeed;
    public Collider weaponCollider;
    public PlayerUIManager playerUIManager;
    public int maxHp = 100;
    public int hp;

    Rigidbody rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        playerUIManager.Init(this);
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        HideColliderWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        // キーボード入力で移動させる
        x =  Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        //攻撃入力
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
    }

    private void FixedUpdate()
    {
        Vector3 direction = transform.position + new Vector3(x, 0, z) * moveSpeed;
        transform.LookAt(direction);
        //　速度設定
        rb.velocity = new Vector3(x, 0, z) * moveSpeed;
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }

    //武器の判定を有効にしたり / 消したりする
    public void HideColliderWeapon()
    {
        weaponCollider.enabled = false;
    }
    public void ShowColliderWeapon()
    {
        weaponCollider.enabled = true;
    }

    void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
        playerUIManager.UpdateHP(hp);
        Debug.Log("Player残りHP:" + hp);
    }

    private void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            //ダメージを与えるものにぶつかったら
            animator.SetTrigger("Hurt");
            Damage(damager.damage);
        }
    }
}
