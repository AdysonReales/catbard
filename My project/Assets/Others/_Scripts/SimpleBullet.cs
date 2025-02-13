using UnityEngine;

public class SimpleBullet : MonoBehaviour
{
    public float lifeTime = 3f; // Time before the bullet destroys itself

    void Start()
    {
        // Destroy the bullet after its lifetime expires
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy the bullet on collision
        Destroy(gameObject);
    }
}
