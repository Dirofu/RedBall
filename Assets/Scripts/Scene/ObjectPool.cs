using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public void Initialized(GameObject prefab, int capacity, GameObject container, List<GameObject> pool)
    {
        for (int i = 0; i < capacity; i++)
        {
            GameObject spawned = Instantiate(prefab, container.transform);
            spawned.SetActive(false);

            pool.Add(spawned);
        }
    }

    public bool TryGetObject(out GameObject result, List<GameObject> pool)
    {
        result = pool.First(@object => @object.activeSelf == false);

        return result != null;
    }
}
