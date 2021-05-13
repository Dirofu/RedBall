using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _offsetX;

    private Vector3 _direction;

    private void Update()
    {
        _direction = new Vector3(_player.transform.position.x + _offsetX, transform.position.y, transform.position.z);
        gameObject.transform.position = _direction;
    }
}
