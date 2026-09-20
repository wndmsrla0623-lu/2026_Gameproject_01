using UnityEngine;
using System.Collections.Generic;
public class FirstScripts : MonoBehaviour
{

    /// const int DANGER_HP = 40;
    /// const int WARNING_HP = 60;
    /// const int DEAD_HP = 0;
    /// 

    //void Start()
    //{
    //     Debug.Log(PlusNumber(3, 97));
    //}

    // int PlusNumber(int a, int b)
    // {
    //     int sum = a + b;
    //     return sum;
    // }

    // int MinusNumber(int a, int b)
    // {
    //     int sum = a - b;
    //     return sum;
    // }

    // int TimesNumber(int a, int b)
    // {
    //     int sum = a * b;
    //     return sum;
    // }

    // int DividedNumber(int a, int b)
    // {
    //     int sum = a / b;
    //     return sum;
    // }

    //int[] myArray2 = { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30};
    //public List<int> myList2 = new List<int>() { 4,6,9,12,15,18,19,21,22,23,24,25}

    //void Start()
    //{
    //    for (int i = 0; i < myArray2.Length; i++)
    //    {
    //        Debug.Log(myArray2[i]);
    //    }

    //    foreach (int value in myList2)
    //    {
    //        Debug.Log(value);
    //    }
    //}

    List<string> names = new List<string> {"Alice", "Bob", "Charlie"};

    void Start()
    {
        for (int i = names.Count - 1; i >= 0; i--)
        {
            Debug.Log(names[i]);
        }
    }
}