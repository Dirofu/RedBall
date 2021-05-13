using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLine : MonoBehaviour
{
    [SerializeField] private GameObject[] _coins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Destroyer>())
        {
            gameObject.SetActive(false);
            transform.position = new Vector2(0, 0);

            foreach (var coin in _coins)
            {
                coin.SetActive(true);
            }
        }
    }
}
