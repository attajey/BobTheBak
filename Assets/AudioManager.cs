using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip pickupSfx;
    private AudioSource audioSource;

    void Start()
    {
        audioSource= GetComponent<AudioSource>();
        GuitarPick.OnGuitarPickCollected += PlayPickupSfx;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayPickupSfx()
    {
        audioSource.clip = pickupSfx;
        audioSource.Play();
    }
}
