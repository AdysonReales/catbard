using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public GameObject bulletPrefab;   // Bullet prefab
    public Transform firePoint;       // The point from which the bullet will be fired
    public float bulletSpeed = 10f;   // Speed of the bullet

    private bool isFacingRight = true; // Keep track of whether the player is facing right

    void Update()
    {
        HandleMovementDirection();

        if (Input.GetButtonDown("Fire1"))  // Check for fire input (left mouse button or space)
        {
            Shoot();
        }
    }

    void HandleMovementDirection()
    {
        // Check for simultaneous or individual key presses
        bool pressLeft = Input.GetKey(KeyCode.A);
        bool pressRight = Input.GetKey(KeyCode.D);

        if (pressLeft && !pressRight)
        {
            isFacingRight = false;
        }
        else if (pressRight && !pressLeft)
        {
            isFacingRight = true;
        }
    }

    void Shoot()
    {
        // Determine shoot direction based on whether the player is facing right or left
        Vector2 shootDirection = isFacingRight ? Vector2.right : Vector2.left;

        // Instantiate the bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // Set the bullet's velocity based on the shoot direction
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = shootDirection * bulletSpeed;
    }
}
