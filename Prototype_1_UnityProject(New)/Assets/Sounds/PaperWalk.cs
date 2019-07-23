using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperWalk : MonoBehaviour
{
    public AudioClip paperWalk;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        audioSource.PlayOneShot(paperWalk);
    }
}
