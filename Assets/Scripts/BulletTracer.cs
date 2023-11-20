using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public Rigidbody2D rb;
    public int damage = 10;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
          /*  Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            // Apply damage to enemy
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
          */
            // Destroy the bullet when it hits an object with the "Enemy" tag
            Destroy(gameObject);
            Debug.Log("Enemy Hit!");
        }
    }
}