using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageManager : MonoBehaviour
{
    // メッセージパネルの
    // ・表示
    // ・非表示
    // ・メッセージ変更
    public static MessageManager Instance;

    public GameObject messagePanel;
    public TextMeshProUGUI message;

    void Awake()
    {
        Instance = this;
    }

    public void HideMessagePanel()
    {
        // メッセージパネルを非表示にする処理
        messagePanel.SetActive(false);
    }

    public void ShowMessage(string msg)
    {
        // メッセージパネルのメッセージを更新する処理
        message.text = msg;
        ShowPanel();
    }

        void ShowPanel()
    {
        // メッセージパネルを表示する処理
        messagePanel.SetActive(true);
    }
}
