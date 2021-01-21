using UnityEngine;

public class Question : MonoBehaviour
{
    int[] numbers = { 10, 20, 30, 1, 2, 33, -33, 44, 556, 54345, 3434 };
    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}