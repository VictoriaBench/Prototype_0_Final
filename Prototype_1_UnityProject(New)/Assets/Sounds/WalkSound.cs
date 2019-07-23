using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio; //Ref audio features (for sound)
using UnityEngine;

public class WalkSound : MonoBehaviour
{
    public AudioClip walkSound;

    public AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        //Play enemy sound when walking
        soundSource.clip = walkSound; //audioclip set to walk sound
    }

    // Update is called once per frame
    void Awake()
    {
        //Plays walking sound
        soundSource.Play();
    }
}
