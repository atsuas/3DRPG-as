using UnityEngine;

public class Sample : MonoBehaviour
{
    //宣言方法
    int[] a = { 10, 2, 5, 80 };
    int[] b = new int[] { 20, 40, 6, 8 };
    int[] c = new int[4] { 30, 2, 3, 6 };

    void Start()
    {
        //取得
        int x = a[1];
        Debug.Log(x);

        //変更
        a[1] = 7;
        Debug.Log(a[1]);

        //長さ
        Debug.Log(a.Length);

        string[] names = { "あつ", "atsu", "as" };
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }
    }
}
