using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _platform;
    [SerializeField] private Transform _spawnPoint;

    private float _spawnDistance = 9f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlatformEdge>())
        {
            _spawnPoint.position = new Vector3(transform.position.x + _spawnDistance, transform.position.y, transform.position.z);
            GameObject spawned = Instantiate(_platform, _spawnPoint);
            spawned.transform.SetParent(null);
            _spawnPoint.position = transform.position;
        }
    }
}
