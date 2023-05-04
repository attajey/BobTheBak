using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 100;

    //[SerializeField] private GameObject deathEffect;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    private float timer;

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth = 100;
    [SerializeField] private Healthbar healthbar;

    private void Start()
    {
        healthbar.SetMaxHealth(maxHealth);

    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //throw new NotImplementedException();
    }

}
