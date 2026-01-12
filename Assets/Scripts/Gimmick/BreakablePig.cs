using UnityEngine;

public class BreakablePig : MonoBehaviour
{
    // クリックした時に、ハンマーを持っていれば、破壊する
    // 持っていなければログを出す
    public GameObject pigObj;
     public GameObject brokenPigObj;

    public void OnThis()
    {
         bool hasHammer = ItemBox.instance.CanUseItem(ItemManager.Item.Hammer); 
        if (hasHammer)
        {
            Break();
        } 
        else
        {
            MessageManager.Instance.ShowMessage("壊せそうだ。");
        }
    }

    void Break()
    {
        pigObj.SetActive(false);
        brokenPigObj.SetActive(true);
         ItemBox.instance.UseItem(ItemManager.Item.Hammer);
    }
}
