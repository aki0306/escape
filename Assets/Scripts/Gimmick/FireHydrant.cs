using UnityEngine;
using System.Collections.Generic;

public class FireHydrant : MonoBehaviour
{
    public GameObject openObj;

    // 連続入力の実装
        enum Direction
    {
        Left,
        Right
    }
    // Playerの入力
    List<Direction> userInput = new List<Direction>();
    // 正解の連続入力：右、左、左、右、右
    Direction[] correctAnswer = { Direction.Right, Direction.Left, Direction.Left, Direction.Right, Direction.Right };


    public void OnButton(int type)
    {
        // type:0 左
        if (type == 0)
        {
            userInput.Add(Direction.Left);
        }
        // type:1 右
        else if (type == 1)
        {
            userInput.Add(Direction.Right);
        }

        if (userInput.Count == 5)
        {
            if (IsAllClear())
            {
                Clear();
            }
            else
            {
                ResetInput();
            }
        }
    }

    bool IsAllClear()
    {
        for (int i = 0; i < userInput.Count; i++)
        {
            if (userInput[i] != correctAnswer[i])
            {
                return false;
            }
        }
        return true;
    }

    void ResetInput()
    {
        MessageManager.Instance.ShowMessage("入力が間違っているようだ");
        userInput.Clear();
    }

    void Clear()
    {
        openObj.SetActive(true);
    }
}
