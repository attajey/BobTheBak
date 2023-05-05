using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth = 100;
    [SerializeField] private int damageFromEnemy = 20;


    [SerializeField] private Healthbar healthbar;
    [SerializeField] private AudioClip[] walkSfx;
    [SerializeField] private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(damageFromEnemy);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }

    void PlayRandomWalkSfx()
    {
        audioSource.clip = walkSfx[UnityEngine.Random.Range(0, walkSfx.Length)];
        audioSource.Play();
    }
}
