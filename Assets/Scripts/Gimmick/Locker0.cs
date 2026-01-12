using UnityEngine;

public class Locker0 : MonoBehaviour
{
    // ダイアルをクリアしたら、ロッカーをオープンにする
    public GameObject openObj;
    public void Open()
    {
        openObj.SetActive(true);    
    }
}
