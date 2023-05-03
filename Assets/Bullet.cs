using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private int damage = 40;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("Shot " + hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        //Destroy(hitInfo.gameObject);
    }

}
