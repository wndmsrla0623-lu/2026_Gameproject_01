using UnityEngine;
public class FirstScripts : MonoBehaviour
{

    /// const int DANGER_HP = 40;
    /// const int WARNING_HP = 60;
    /// const int DEAD_HP = 0;
    /// 

   void Start()
   {
        Debug.Log(PlusNumber(3, 97));
   }

    int PlusNumber(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    int MinusNumber(int a, int b)
    {
        int sum = a - b;
        return sum;
    }

    int TimesNumber(int a, int b)
    {
        int sum = a * b;
        return sum;
    }

    int DividedNumber(int a, int b)
    {
        int sum = a / b;
        return sum;
    }
}