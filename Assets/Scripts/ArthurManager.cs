using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArthurManager : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetFloat("MoveSpeed", 1.1f);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            animator.SetFloat("MoveSpeed", 0);
        }

    }

    public void HitLog()
    {
        Debug.Log("Hit!!!");
    }
}
