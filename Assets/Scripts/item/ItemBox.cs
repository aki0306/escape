using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public GameObject[] boxes;

    public static ItemBox instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[i].SetActive(false);
        }
    }

    public void SetItem(ItemManager.Item item)
    {
        int index = (int)item;
        boxes[index].SetActive(true);
    }

    public bool CanUseItem(ItemManager.Item item)
    {
        int index = (int)item;
        return boxes[index].activeSelf;
    }

    public void UseItem(ItemManager.Item item)
    {
        int index = (int)item;
        boxes[index].SetActive(false);
    }
}
