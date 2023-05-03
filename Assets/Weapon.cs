using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private AudioClip[] gunSfx;
    [SerializeField] private Animator animator;

    [SerializeField] private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            PlayRandomGunSound();
            animator.SetBool("isShooting", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("isShooting", false);

        }

    }

    private void Shoot()
    {
        // Shooting Logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //throw new NotImplementedException();
    }

    void PlayRandomGunSound()
    {
        audioSource.clip = gunSfx[UnityEngine.Random.Range(0, gunSfx.Length)];
        audioSource.Play();
    }
}
