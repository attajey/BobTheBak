using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarPick : MonoBehaviour, ICollectible
{
    public static event Action OnGuitarPickCollected;
    public static int collected = 0;

    public void Collect()
    {
        collected++;
        Destroy(gameObject);
        OnGuitarPickCollected?.Invoke();
    }
}
