using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// 按鈕開始遊戲事件
/// </summary>

namespace s
{

    public class startbutton : MonoBehaviour
    {
        private void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(OnClick);
        }

        //按鈕轉換場景
        void OnClick()
        {
            SceneManager.LoadScene("level");
        }
    }
}