using UnityEngine;

public class TeaServer : MonoBehaviour
{
    public Tanuki tanuki;

    public void OnThis()
    {
        bool movedTanuki = tanuki.moved;
        if (movedTanuki)
        {
            gameObject.SetActive(false);
        }
        else
        {
            MessageManager.Instance.ShowMessage("たぬきがいて動かせない");
        }
    }
}
