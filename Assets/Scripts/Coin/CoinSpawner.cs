using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;


public class CoinSpawner : ObjectPool
{
    [SerializeField] private float _delayFrom;
    [SerializeField] private float _delayTo;
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
            yield return new WaitForSeconds(Random.Range(_delayFrom, _delayTo));
            SpawnCoinPattern();
        }
    }

    private void SpawnCoinPattern()
    {
        if (TryGetElement(out GameObject poolObject))
        {
            poolObject.SetActive(true); 
            var coinPattern = poolObject.GetComponent<CoinPattern>();
            coinPattern.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform.position;
        }
    }
}