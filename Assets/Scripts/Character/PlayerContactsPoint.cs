using System;
using UnityEngine;

public class PlayerContactsPoint : MonoBehaviour
{
    public event Action CointCollected;
    public event Action BirdDestroyed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipes"))
        {
            BirdDestroyed?.Invoke();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            CointCollected?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
