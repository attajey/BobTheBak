using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarPick : MonoBehaviour, ICollectible
{
    public static event Action OnGuitarPickCollected;
    public static int collected = 0;

    //[SerializeField] private AudioSource audioSource;
    //[SerializeField] private AudioClip pickUpSfx;

    //public SpriteRenderer spriteRenderer;
    //public Sprite[] sprites;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        //audioSource.enabled= true;
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //ChooseRandomSprite();
    }

    public void Collect()
    {
        collected++;
        //audioSource.clip= pickUpSfx;
        //audioSource.Play();
        OnGuitarPickCollected?.Invoke();
        Destroy(gameObject);
    }

    //private void ChooseRandomSprite()
    //{
    //    spriteRenderer.sprite = sprites[UnityEngine.Random.Range(0, sprites.Length)];
    //}
}
