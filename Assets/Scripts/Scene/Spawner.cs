using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private int _templateCapacity;
    [SerializeField] private GameObject _container;

    [SerializeField] private float _spawnTime;
    [SerializeField] private Transform[] _spawnPoints;

    [SerializeField] private ObjectPool _pool;

    private List<GameObject> _templatePool = new List<GameObject>();

    private float _lastSpawnTime;

    private void Start()
    {
        _pool.Initialized(_template, _templateCapacity, _container, _templatePool);
    }

    private void Update()
    {
        _lastSpawnTime += Time.deltaTime;

        if (_lastSpawnTime > _spawnTime)
        {
            if (_pool.TryGetObject(out GameObject template, _templatePool))
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
