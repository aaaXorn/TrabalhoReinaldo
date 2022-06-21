using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float spawn_timer;
    private float timer;

    [SerializeField]
    private Vector3[] Offset;

    [SerializeField]
    private PoolManager poolM;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawn_timer, spawn_timer);
    }

    private void SpawnEnemy()
    {
        GameObject enemy = poolM.GetFromPool();

        int pos = Random.Range(0, Offset.Length);

        enemy.SetActive(true);
        enemy.transform.position = transform.position + Offset[pos];

        print("BBB");
    }
}
