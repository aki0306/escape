using UnityEngine;

public class Locker : MonoBehaviour
{
    // クリックした時に、鍵を持っていれば、Openにする
    // 持っていなければログを出す
    public GameObject openObj;

    public void OnThis()
    {
         bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key); 
        if (hasKey)
        {
            Open();
        }
    }

    void Open()
    {
        openObj.SetActive(true);
         ItemBox.instance.UseItem(ItemManager.Item.Key);
    }
}
