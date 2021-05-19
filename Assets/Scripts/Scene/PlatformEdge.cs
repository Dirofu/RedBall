using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformEdge : MonoBehaviour
{
    [SerializeField] private GameObject _platform;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.GetComponent<Destroyer>())
        {
            Destroy(_platform);
        }
    }
}
