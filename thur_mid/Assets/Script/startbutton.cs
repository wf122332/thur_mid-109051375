using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// ���s�}�l�C���ƥ�
/// </summary>

namespace s
{

    public class startbutton : MonoBehaviour
    {
        private void Start()
        {
            this.GetComponent<Button>().onClick.AddListener(OnClick);
        }

        //���s�ഫ����
        void OnClick()
        {
            SceneManager.LoadScene("level");
        }
    }
}