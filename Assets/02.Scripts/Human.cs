using UnityEngine;

public class Human : MonoBehaviour
{
    public string myName;
    private int myAge;
    private float myHeight;
    bool isSolo;

    public void Eat()
    {
        Debug.Log("냠냠 먹는다.");
    }

    public void Sleep()
    {
        Debug.Log("쿨쿨 잔다.");
    }

    public void PowerPush()
    {
        Debug.Log("힘껏 장 내 물질을 밀어낸다.");
    }
    
}
