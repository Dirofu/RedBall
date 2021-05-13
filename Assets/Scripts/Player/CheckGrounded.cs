using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrounded : MonoBehaviour
{
    [SerializeField] private GameObject _ground;

    public bool IsGrounded { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer.ToString() == _ground.layer.ToString())
        {
            IsGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer.ToString() == _ground.layer.ToString())
        {
            IsGrounded = false;
        }
    }
}
