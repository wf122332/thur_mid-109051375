using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵人攻擊系統
/// </summary>

namespace s
{

    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            //重複呼叫子彈生成指令
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}