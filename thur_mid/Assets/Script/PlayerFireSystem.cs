using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 玩家攻擊系統
/// </summary>

namespace s
{

    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            //press"space"> make bullet
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}