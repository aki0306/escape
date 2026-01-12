using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject leftObj;
    public GameObject rightObj;
    public void OnThis()
    {
        bool hasCard = ItemBox.instance.CanUseItem(ItemManager.Item.Card);
        if (hasCard)
        {
            Open();
        }
        else
        {
            MessageManager.Instance.ShowMessage("エレベーターキーが必要だ");
        }
    }

    void Open()
    {
        leftObj.SetActive(false);
        rightObj.SetActive(false);
        ItemBox.instance.UseItem(ItemManager.Item.Card);
    }
}
