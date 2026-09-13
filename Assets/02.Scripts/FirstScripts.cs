using UnityEngine;
public class FirstScripts : MonoBehaviour
{
    void Start()
    {
        Debug.Log(2 != 4 || 6 != 6);
        Debug.Log(2 != 4 && 6 != 6);
        Debug.Log(false == false);
        Debug.Log(false != true);
        Debug.Log(2 != 4);
        Debug.Log(6 != 6);
        Debug.Log(7 != 14);
        Debug.Log(!false);
    }
}
