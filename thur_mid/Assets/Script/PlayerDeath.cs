﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace s
{

    public class PlayerDeath : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            //如果 踫到物件的名稱 就爆炸
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                //刪除物件
                Destroy(gameObject);
                //回到開始畫面
                SceneManager.LoadScene("start");
            }
        }
    }
}