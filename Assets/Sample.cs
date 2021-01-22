using UnityEngine;

public class Sample : MonoBehaviour
{
    
    void Update()
    {
        //キーボードの横方向の入力を受け付ける
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
        //上下の入力
        float z = Input.GetAxis("Vertical");
        Debug.Log(z);

        //Rawは−１、０、１しか取らない
        float rawX = Input.GetAxisRaw("Horizontal");
        Debug.Log(rawX);
        float rawZ = Input.GetAxisRaw("Vertical");
        Debug.Log(rawZ);

        //ボタン入力
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Spaceを押した");
        }
        // Jを押したとき
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Jを押した");
        }
    }
}