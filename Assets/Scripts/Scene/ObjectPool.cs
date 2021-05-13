﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;

    private List<GameObject> _pool = new List<GameObject>();

    protected void Initialized(GameObject prefab, int capacity)
    {
        for (int i = 0; i < capacity; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.SetActive(false);

            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.First(@object => @object.activeSelf == false);

        return result != null;
    }
}
