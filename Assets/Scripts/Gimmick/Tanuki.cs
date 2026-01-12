using UnityEngine;

public class Tanuki : MonoBehaviour
{
    public bool moved = false;
    public void OnThis()
    {
        bool hasLeaf = ItemBox.instance.CanUseItem(ItemManager.Item.Leaf); 
        if (hasLeaf)
        {
            moved = true;
            gameObject.SetActive(false);
            MessageManager.Instance.ShowMessage("たぬきは消えてしまった。");
            ItemBox.instance.UseItem(ItemManager.Item.Leaf);
        }
        else
        {
            MessageManager.Instance.ShowMessage("たぬきは葉っぱで消えるらしい。");
        }
    }
}
