using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockWalk : MonoBehaviour
{
    public AudioClip rockWalk;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(rockWalk);
    }
}
