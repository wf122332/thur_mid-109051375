using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 角色控制
/// </summary>

namespace S
{ 

public class PlayerController : MonoBehaviour
{
    [Header("移動速度")]
    [SerializeField, Range(0, 10)]
    private float speedVertical = 3.5f;
    [SerializeField, Range(0, 10)]
    private float speedHorizontal = 4f;
 

    private void Update()
    {
        //上下 WS Vertical
        //左右 AD Horizontal
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");


        transform.Translate(
            speedHorizontal * Time.deltaTime * h,
            speedVertical * Time.deltaTime * v, 0);

           
    }

}
}
