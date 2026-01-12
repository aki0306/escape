using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialLocker : MonoBehaviour
{
    // 3つのボタンをそれぞれクリックして絵柄が全て一致すればクリア

    // ボタンの画像を取得
    public Image[] buttons;
    // 表示するマークを列挙
    enum Mark
    {
        Maru,
        Sankaku,
        Hoshi,
        Daia
    }
    // 現在のマーク
    Mark[] currentMarks = { Mark.Maru, Mark.Maru, Mark.Maru };
    Mark[] correctAnswerMarks = { Mark.Maru, Mark.Sankaku, Mark.Hoshi };

    // 表示する画像の素材一覧
    public Sprite[] resourceSprites;

    public UnityEvent ClearEvent;

    public void OnMarkButton(int position)
    {
        // positionのマークを変更する
        ChangeMark(position);
        // positionの画像を表示する
        ShowMark(position);

        if (IsAllClearMark() == true)
        {
            Clear();
        }
    }

    void ChangeMark(int position)
    {
        currentMarks[position]++;
        if (currentMarks[position] > Mark.Daia)
        {
            currentMarks[position] = Mark.Maru;
        }
    }

    void ShowMark(int position)
    {
        int index = (int)currentMarks[position];
        buttons[position].sprite = resourceSprites[index];
    }

    bool IsAllClearMark()
    {
        for (int i = 0; i < currentMarks.Length; i++)
        {
            if (currentMarks[i] != correctAnswerMarks[i])
            {            
                return false;
            }
        }
        return true;
    }

    void Clear()
    {
        MessageManager.Instance.ShowMessage("ロッカーが開いた！");
        ClearEvent.Invoke();
    }
}
