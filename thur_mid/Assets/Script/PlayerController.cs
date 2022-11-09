using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ⱱ��
/// </summary>

namespace S
{ 

public class PlayerController : MonoBehaviour
{
    [Header("���ʳt��")]
    [SerializeField, Range(0, 10)]
    private float speedVertical = 3.5f;
    [SerializeField, Range(0, 10)]
    private float speedHorizontal = 4f;
 

    private void Update()
    {
        //�W�U WS Vertical
        //���k AD Horizontal
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");


        transform.Translate(
            speedHorizontal * Time.deltaTime * h,
            speedVertical * Time.deltaTime * v, 0);

           
    }

}
}
