using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSystemBase : MonoBehaviour
{
    [SerializeField, Header("�l�u�w�s��")]
    private GameObject prefabBullet;
    [SerializeField, Header("�����I")]
    private Transform pointSpawn;

    //�ۭq��k
    //�ͦ��l�u
    //protected �O�@�ŧO:���\�l���O�s��
    protected void SpawnBullet()
    {
        //��Ҥ�(����,�y��,����)
        Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
    }
}
