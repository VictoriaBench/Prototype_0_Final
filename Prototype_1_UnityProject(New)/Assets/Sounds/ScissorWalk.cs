using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorWalk : MonoBehaviour
{
    public AudioClip scissorWalk;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(scissorWalk);
    }
}
