using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _speed;
    [SerializeField] private GroundChecker _grounded;

    private Rigidbody2D _rigidbody;

    public event UnityAction CoinPicked;
    public event UnityAction Dead;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && _grounded.IsGrounded)
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin>())
        {
            CoinPicked?.Invoke();
        }
        else if (collision.gameObject.GetComponent<Barrier>())
        {
            Dead?.Invoke();
        }
    }
}
