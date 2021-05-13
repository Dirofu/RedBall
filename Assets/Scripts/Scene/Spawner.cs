using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private int _coinCapacity;

    [SerializeField] private GameObject _barrier;
    [SerializeField] private int _barrierCapacity;

    [SerializeField] private float _spawnTime;
    [SerializeField] private Transform[] _spawnPoints;

    private float _lastSpawnTime;

    private void Start()
    {
        Initialized(_coin, _coinCapacity);
        Initialized(_barrier, _barrierCapacity);
    }

    private void Update()
    {
        _lastSpawnTime += Time.deltaTime;

        if (_lastSpawnTime > _spawnTime)
        {
            if (TryGetObject(out GameObject template))
            {
                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
                
                _lastSpawnTime = 0;

                SetObject(template, _spawnPoints[spawnPointNumber]);
            }
        }
    }

    private void SetObject(GameObject template, Transform spawnPoint)
    {
        template.transform.position = spawnPoint.position;
        template.SetActive(true);
    }
}
