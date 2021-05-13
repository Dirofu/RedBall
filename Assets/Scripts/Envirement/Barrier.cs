using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Barrier : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        gameObject.transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.GetComponent<Destroyer>())
        {
            gameObject.SetActive(false);
        }
    }
}
