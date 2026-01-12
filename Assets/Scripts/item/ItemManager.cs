using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public enum Item
    {
        Leaf,
        Key,
        Card,
        Hammer,
        Paper
    }

    public Item item;

    // クリックされた時に、
    // ・消す
    // ・ItemBoxに追加する
    public void OnThis()
    {
        gameObject.SetActive(false);
        ItemBox.instance.SetItem(item);
        MessageManager.Instance.ShowMessage(GetItemName(item) + "を手に入れた！");
    }

    string GetItemName(Item item)
    {
        switch (item)
        {
            case Item.Leaf:
                return "葉っぱ";
            case Item.Key:
                return "金庫の鍵";
            case Item.Card:
                return "エレベーターキー";
            case Item.Hammer:
                return "ハンマー";
            case Item.Paper:
                return "焦げた紙";
            default:
                return "不明なアイテム";
        }
    }
}
