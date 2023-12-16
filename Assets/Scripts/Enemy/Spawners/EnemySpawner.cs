using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemySpawner : ObjectPool
{
    [SerializeField] private float _delay;
    [SerializeField] private SpawnPoint[] _spawnPoints;
    private void Start()
    {
        Initialize();
        StartCoroutine(Spawn());
    }
    

    private IEnumerator Spawn()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(_delay);
        }
    }

    private void SpawnEnemy()
    {
        if (TryGetElement(out GameObject poolObject))
        {
            poolObject.SetActive(true);
            Enemy enemy = poolObject.GetComponent<Enemy>();
            enemy.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform.position;
        }
    }
}