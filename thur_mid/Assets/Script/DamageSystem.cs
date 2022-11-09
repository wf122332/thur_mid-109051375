using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ˮ`�t��
/// </summary>

namespace s
{

    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplosion;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            //�p�G ��쪫�󪺦W�� �N�z��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                //�R������
                Destroy(gameObject);
            }
        }
    }
}
